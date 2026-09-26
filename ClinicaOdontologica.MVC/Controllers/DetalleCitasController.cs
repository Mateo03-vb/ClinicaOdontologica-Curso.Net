
using Microsoft.AspNetCore.Mvc;
using ClinicaOdontologica.Consumer;
using ClinicaOdontologica;

public class DetalleCitasController : Controller
{
    // GET: DETALLECITAS
    public ActionResult Index()
    {
        var detalleCitas = CRUD<DetalleCita>.GetAll();
        return View(detalleCitas);
    }

    // GET: DETALLECITAS/Details/5
    public ActionResult Details(int iddetallecita)
    {
        var detalleCita = CRUD<DetalleCita>.GetById(iddetallecita);
        if (iddetallecita == null)
        {
            return NotFound();
        }
        return View(detalleCita);
    }

    // GET: DETALLECITAS/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: DETALLECITAS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(DetalleCita detalleCita)
    {
        try
        {
            CRUD<DetalleCita>.Create(detalleCita);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            // Handle the exception (e.g., log it, display an error message, etc.)
            ModelState.AddModelError("", ex.Message);
            return View(detalleCita);
        }
    }

    // GET: DETALLECITAS/Edit/5
    public ActionResult Edit(int iddetallecita)
    {
        var detalleCita = CRUD<DetalleCita>.GetById(iddetallecita);
        if (detalleCita == null)
        {
            return NotFound();
        }
        return View(detalleCita);
    }

    // POST: DETALLECITAS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int iddetallecita, DetalleCita detalleCita)
    {
        try
        {
            CRUD<DetalleCita>.Update(iddetallecita, detalleCita);
            return RedirectToAction(nameof(Index));

        }
        catch (Exception ex)
        {
            // Handle the exception (e.g., log it, display an error message, etc.)
            ModelState.AddModelError("", ex.Message);
            return View(detalleCita);
        }
    }

    // GET: DETALLECITAS/Delete/5
    public ActionResult Delete(int iddetallecita)
    {
        var detalleCita = CRUD<DetalleCita>.GetById(iddetallecita);
        if (detalleCita == null)
        {
            return NotFound();
        }

        return View(detalleCita);
    }

    // POST: DETALLECITAS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int iddetallecita, DetalleCita detalleCita)
    {
        try
        {
            CRUD<DetalleCita>.Delete(iddetallecita);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(detalleCita);
        }
    }
}
