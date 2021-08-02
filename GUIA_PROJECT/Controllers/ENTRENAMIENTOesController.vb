Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports GUIA_PROJECT

Namespace Controllers
    Public Class ENTRENAMIENTOesController
        Inherits System.Web.Mvc.Controller

        Private db As New GUIA_ENTRENAMIENTOEntities

        ' GET: ENTRENAMIENTOes
        Function Index() As ActionResult
            Dim eNTRENAMIENTO = db.ENTRENAMIENTO.Include(Function(e) e.CLIENTE).Include(Function(e) e.DIETA).Include(Function(e) e.EJERCICIO).Include(Function(e) e.ENTRENADORES)
            Return View(eNTRENAMIENTO.ToList())
        End Function

        ' GET: ENTRENAMIENTOes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim eNTRENAMIENTO As ENTRENAMIENTO = db.ENTRENAMIENTO.Find(id)
            If IsNothing(eNTRENAMIENTO) Then
                Return HttpNotFound()
            End If
            Return View(eNTRENAMIENTO)
        End Function

        ' GET: ENTRENAMIENTOes/Create
        Function Create() As ActionResult
            ViewBag.CLI_ID = New SelectList(db.CLIENTE, "CLI_ID", "CLI_NOMBRE")
            ViewBag.DIE_ID = New SelectList(db.DIETA, "DIE_ID", "NOMBRE_DIETA")
            ViewBag.EJER_ID = New SelectList(db.EJERCICIO, "EJER_ID", "EJER_RUTINA")
            ViewBag.ENT_ID = New SelectList(db.ENTRENADORES, "ENT_ID", "ENT_NOMBRE")
            Return View()
        End Function

        ' POST: ENTRENAMIENTOes/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ENT_ID,CLI_ID,EJER_ID,DIE_ID,FECHA")> ByVal eNTRENAMIENTO As ENTRENAMIENTO) As ActionResult
            If ModelState.IsValid Then
                db.ENTRENAMIENTO.Add(eNTRENAMIENTO)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.CLI_ID = New SelectList(db.CLIENTE, "CLI_ID", "CLI_NOMBRE", eNTRENAMIENTO.CLI_ID)
            ViewBag.DIE_ID = New SelectList(db.DIETA, "DIE_ID", "NOMBRE_DIETA", eNTRENAMIENTO.DIE_ID)
            ViewBag.EJER_ID = New SelectList(db.EJERCICIO, "EJER_ID", "EJER_RUTINA", eNTRENAMIENTO.EJER_ID)
            ViewBag.ENT_ID = New SelectList(db.ENTRENADORES, "ENT_ID", "ENT_NOMBRE", eNTRENAMIENTO.ENT_ID)
            Return View(eNTRENAMIENTO)
        End Function

        ' GET: ENTRENAMIENTOes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim eNTRENAMIENTO As ENTRENAMIENTO = db.ENTRENAMIENTO.Find(id)
            If IsNothing(eNTRENAMIENTO) Then
                Return HttpNotFound()
            End If
            ViewBag.CLI_ID = New SelectList(db.CLIENTE, "CLI_ID", "CLI_NOMBRE", eNTRENAMIENTO.CLI_ID)
            ViewBag.DIE_ID = New SelectList(db.DIETA, "DIE_ID", "NOMBRE_DIETA", eNTRENAMIENTO.DIE_ID)
            ViewBag.EJER_ID = New SelectList(db.EJERCICIO, "EJER_ID", "EJER_RUTINA", eNTRENAMIENTO.EJER_ID)
            ViewBag.ENT_ID = New SelectList(db.ENTRENADORES, "ENT_ID", "ENT_NOMBRE", eNTRENAMIENTO.ENT_ID)
            Return View(eNTRENAMIENTO)
        End Function

        ' POST: ENTRENAMIENTOes/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ENT_ID,CLI_ID,EJER_ID,DIE_ID,FECHA")> ByVal eNTRENAMIENTO As ENTRENAMIENTO) As ActionResult
            If ModelState.IsValid Then
                db.Entry(eNTRENAMIENTO).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.CLI_ID = New SelectList(db.CLIENTE, "CLI_ID", "CLI_NOMBRE", eNTRENAMIENTO.CLI_ID)
            ViewBag.DIE_ID = New SelectList(db.DIETA, "DIE_ID", "NOMBRE_DIETA", eNTRENAMIENTO.DIE_ID)
            ViewBag.EJER_ID = New SelectList(db.EJERCICIO, "EJER_ID", "EJER_RUTINA", eNTRENAMIENTO.EJER_ID)
            ViewBag.ENT_ID = New SelectList(db.ENTRENADORES, "ENT_ID", "ENT_NOMBRE", eNTRENAMIENTO.ENT_ID)
            Return View(eNTRENAMIENTO)
        End Function

        ' GET: ENTRENAMIENTOes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim eNTRENAMIENTO As ENTRENAMIENTO = db.ENTRENAMIENTO.Find(id)
            If IsNothing(eNTRENAMIENTO) Then
                Return HttpNotFound()
            End If
            Return View(eNTRENAMIENTO)
        End Function

        ' POST: ENTRENAMIENTOes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim eNTRENAMIENTO As ENTRENAMIENTO = db.ENTRENAMIENTO.Find(id)
            db.ENTRENAMIENTO.Remove(eNTRENAMIENTO)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
