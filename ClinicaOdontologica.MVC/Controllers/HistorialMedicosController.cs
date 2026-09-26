
using Microsoft.AspNetCore.Mvc;
using ClinicaOdontologica.Consumer;
using ClinicaOdontologica;

public class HistorialMedicosController : Controller
{
    // GET: HISTORIALMEDICOS
    public ActionResult Index()
    {
        var historialMedicos = CRUD<HistorialMedico>.GetAll();
        return View(historialMedicos);
    }

    // GET: HISTORIALMEDICOS/Details/5
    public ActionResult Details(int idhistorialmedico)
    {
        var historialMedico = CRUD<HistorialMedico>.GetById(idhistorialmedico);
        if (idhistorialmedico == null)
        {
            return NotFound();
        }
        return View(historialMedico);
    }

    // GET: HISTORIALMEDICOS/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: HISTORIALMEDICOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(HistorialMedico historialMedico)
    {
        try
        {
            CRUD<HistorialMedico>.Create(historialMedico);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            // Handle the exception (e.g., log it, display an error message, etc.)
            ModelState.AddModelError("", ex.Message);
            return View(historialMedico);
        }
    }

    // GET: HISTORIALMEDICOS/Edit/5
    public ActionResult Edit(int idhistorialmedico)
    {
        var historialMedico = CRUD<HistorialMedico>.GetById(idhistorialmedico);
        if (historialMedico == null)
        {
            return NotFound();
        }
        return View(historialMedico);
    }

    // POST: HISTORIALMEDICOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int idhistorialmedico, HistorialMedico historialMedico)
    {
        try
        {
            CRUD<HistorialMedico>.Update(idhistorialmedico, historialMedico);
            return RedirectToAction(nameof(Index));

        }
        catch (Exception ex)
        {
            // Handle the exception (e.g., log it, display an error message, etc.)
            ModelState.AddModelError("", ex.Message);
            return View(historialMedico);
        }
    }

    // GET: HISTORIALMEDICOS/Delete/5
    public ActionResult Delete(int idhistorialmedico)
    {
        var historialMedico = CRUD<HistorialMedico>.GetById(idhistorialmedico);
        if (historialMedico == null)
        {
            return NotFound();
        }

        return View(historialMedico);
    }

    // POST: HISTORIALMEDICOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int idhistorialmedico, HistorialMedico historialMedico)
    {
        try
        {
            CRUD<HistorialMedico>.Delete(idhistorialmedico);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(historialMedico);
        }
    }
}
