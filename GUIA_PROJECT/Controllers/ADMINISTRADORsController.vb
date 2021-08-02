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
    Public Class ADMINISTRADORsController
        Inherits System.Web.Mvc.Controller

        Private db As New GUIA_ENTRENAMIENTOEntities

        ' GET: ADMINISTRADORs
        Function Index() As ActionResult
            Dim aDMINISTRADOR = db.ADMINISTRADOR.Include(Function(a) a.ESTABLECIMIENTO)
            Return View(aDMINISTRADOR.ToList())
        End Function

        ' GET: ADMINISTRADORs/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim aDMINISTRADOR As ADMINISTRADOR = db.ADMINISTRADOR.Find(id)
            If IsNothing(aDMINISTRADOR) Then
                Return HttpNotFound()
            End If
            Return View(aDMINISTRADOR)
        End Function

        ' GET: ADMINISTRADORs/Create
        Function Create() As ActionResult
            ViewBag.EST_ID = New SelectList(db.ESTABLECIMIENTO, "EST_ID", "EST_NOMBRE")
            Return View()
        End Function

        ' POST: ADMINISTRADORs/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="EST_ID,ADMIN_ID,ADMIN_NOMBRE,ADMIN_TELEFONO,ADMIN_EMAIL,ADMIN_APELLIDO")> ByVal aDMINISTRADOR As ADMINISTRADOR) As ActionResult
            If ModelState.IsValid Then
                db.ADMINISTRADOR.Add(aDMINISTRADOR)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EST_ID = New SelectList(db.ESTABLECIMIENTO, "EST_ID", "EST_NOMBRE", aDMINISTRADOR.EST_ID)
            Return View(aDMINISTRADOR)
        End Function

        ' GET: ADMINISTRADORs/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim aDMINISTRADOR As ADMINISTRADOR = db.ADMINISTRADOR.Find(id)
            If IsNothing(aDMINISTRADOR) Then
                Return HttpNotFound()
            End If
            ViewBag.EST_ID = New SelectList(db.ESTABLECIMIENTO, "EST_ID", "EST_NOMBRE", aDMINISTRADOR.EST_ID)
            Return View(aDMINISTRADOR)
        End Function

        ' POST: ADMINISTRADORs/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="EST_ID,ADMIN_ID,ADMIN_NOMBRE,ADMIN_TELEFONO,ADMIN_EMAIL,ADMIN_APELLIDO")> ByVal aDMINISTRADOR As ADMINISTRADOR) As ActionResult
            If ModelState.IsValid Then
                db.Entry(aDMINISTRADOR).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EST_ID = New SelectList(db.ESTABLECIMIENTO, "EST_ID", "EST_NOMBRE", aDMINISTRADOR.EST_ID)
            Return View(aDMINISTRADOR)
        End Function

        ' GET: ADMINISTRADORs/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim aDMINISTRADOR As ADMINISTRADOR = db.ADMINISTRADOR.Find(id)
            If IsNothing(aDMINISTRADOR) Then
                Return HttpNotFound()
            End If
            Return View(aDMINISTRADOR)
        End Function

        ' POST: ADMINISTRADORs/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim aDMINISTRADOR As ADMINISTRADOR = db.ADMINISTRADOR.Find(id)
            db.ADMINISTRADOR.Remove(aDMINISTRADOR)
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
