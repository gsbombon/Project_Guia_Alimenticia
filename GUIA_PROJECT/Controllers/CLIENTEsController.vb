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
    Public Class CLIENTEsController
        Inherits System.Web.Mvc.Controller

        Private db As New GUIA_ENTRENAMIENTOEntities

        ' GET: CLIENTEs
        Function Index() As ActionResult
            Dim cLIENTE = db.CLIENTE.Include(Function(c) c.ESTABLECIMIENTO)
            Return View(cLIENTE.ToList())
        End Function

        ' GET: CLIENTEs/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cLIENTE As CLIENTE = db.CLIENTE.Find(id)
            If IsNothing(cLIENTE) Then
                Return HttpNotFound()
            End If
            Return View(cLIENTE)
        End Function

        ' GET: CLIENTEs/Create
        Function Create() As ActionResult
            ViewBag.EST_ID = New SelectList(db.ESTABLECIMIENTO, "EST_ID", "EST_NOMBRE")
            Return View()
        End Function

        ' POST: CLIENTEs/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="EST_ID,CLI_ID,CLI_NOMBRE,CLI_APELLIDO,CLI_EMAIL,CLI_TELEFONO,CLI_DIRECCION")> ByVal cLIENTE As CLIENTE) As ActionResult
            If ModelState.IsValid Then
                db.CLIENTE.Add(cLIENTE)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EST_ID = New SelectList(db.ESTABLECIMIENTO, "EST_ID", "EST_NOMBRE", cLIENTE.EST_ID)
            Return View(cLIENTE)
        End Function

        ' GET: CLIENTEs/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cLIENTE As CLIENTE = db.CLIENTE.Find(id)
            If IsNothing(cLIENTE) Then
                Return HttpNotFound()
            End If
            ViewBag.EST_ID = New SelectList(db.ESTABLECIMIENTO, "EST_ID", "EST_NOMBRE", cLIENTE.EST_ID)
            Return View(cLIENTE)
        End Function

        ' POST: CLIENTEs/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="EST_ID,CLI_ID,CLI_NOMBRE,CLI_APELLIDO,CLI_EMAIL,CLI_TELEFONO,CLI_DIRECCION")> ByVal cLIENTE As CLIENTE) As ActionResult
            If ModelState.IsValid Then
                db.Entry(cLIENTE).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EST_ID = New SelectList(db.ESTABLECIMIENTO, "EST_ID", "EST_NOMBRE", cLIENTE.EST_ID)
            Return View(cLIENTE)
        End Function

        ' GET: CLIENTEs/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cLIENTE As CLIENTE = db.CLIENTE.Find(id)
            If IsNothing(cLIENTE) Then
                Return HttpNotFound()
            End If
            Return View(cLIENTE)
        End Function

        ' POST: CLIENTEs/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim cLIENTE As CLIENTE = db.CLIENTE.Find(id)
            db.CLIENTE.Remove(cLIENTE)
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
