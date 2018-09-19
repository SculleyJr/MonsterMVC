using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using MonsterMVC.Clients;
using MonsterMVC.Data;
using MonsterMVC.Domain.Data;
using MonsterMVC.Service;

namespace MonsterMVC.Controllers
{
    public class EncountersController : Controller
    {
        private GenerateRandomEncounterService _generateRandomEncounterService = new GenerateRandomEncounterService();
        private DiceRollerService _diceRollerServce = new DiceRollerService();

        private MonsterClient monsterClient = new MonsterClient();

        private MonsterDbContext db = new MonsterDbContext();

        [HttpPost]
        public ActionResult DiceRoller(int numberOfDice, int typeOfDice,int encounterId)
        {
            var encounter = db.Encounters.Find(encounterId);

            var result = _diceRollerServce.DiceRoller(numberOfDice, typeOfDice);
            ViewBag.result = result;

          return RedirectToAction("Details" , new{id = encounter.Id});
        }

        // GET: Encounters
        public ActionResult Index()
        {
            return View(db.Encounters.ToList());
        }

        // GET: Encounters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var encounter = db.Encounters
                .Include(x => x.ActiveMonsters)
                .FirstOrDefault(x => x.Id == id);
            //var encounter = db.Encounters.Find(id);
            if (encounter == null)
            {
                return HttpNotFound();
            }

            return View(encounter);
        }

        // GET: Encounters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Encounters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] Encounter encounter)
        {
            if (ModelState.IsValid)
            {
                db.Encounters.Add(encounter);
                db.SaveChanges();
                return RedirectToAction("Details", new {id = encounter.Id});
            }

            return RedirectToAction("Details", new {id = encounter.Id});
        }

        /// //////////////
        public ActionResult CreateFromRandom()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateFromRandom([Bind(Include = "Id")] Encounter encounter, int numberOfMonsters, int averagePlayerLevel)
        {
            var activeMonsterController = new ActiveMonstersController();

            if (ModelState.IsValid)
            {
                db.Encounters.Add(encounter);
                db.SaveChanges();
                var monsters = _generateRandomEncounterService.GenerateRandomEncounter(numberOfMonsters, averagePlayerLevel);
                foreach (var monster in monsters)
                {
                    var apiMonster = await monsterClient.GetMonster(monster.UrlId);
                    var health = apiMonster.HitPoints;

                    activeMonsterController.CreateFromRandom(encounter.Id, monster.Id, health);
                }
                
                return RedirectToAction("Details", new { id = encounter.Id });
            }
            return RedirectToAction("Details", new { id = encounter.Id });
        }

        // GET: Encounters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Encounter encounter = db.Encounters.Find(id);
            if (encounter == null)
            {
                return HttpNotFound();
            }

            return View(encounter);
        }

        // POST: Encounters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] Encounter encounter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(encounter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(encounter);
        }

        // GET: Encounters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Encounter encounter = db.Encounters.Find(id);
            if (encounter == null)
            {
                return HttpNotFound();
            }

            return View(encounter);
        }

        // POST: Encounters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Encounter encounter = db.Encounters.Find(id);
            db.Encounters.Remove(encounter);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }

        public ActionResult AlterHitPoints(int hp, int damage)
        {
            var monster = new ActiveMonster();
            monster.HealthPoints = hp;
            hp = hp - damage;

            return View("Details");

        }
    }
}
