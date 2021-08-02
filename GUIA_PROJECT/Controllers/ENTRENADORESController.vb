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
    Public Class ENTRENADORESController
        Inherits System.Web.Mvc.Controller

        Private db As New GUIA_ENTRENAMIENTOEntities

        ' GET: ENTRENADORES
        Function Index() As ActionResult
            Dim eNTRENADORES = db.ENTRENADORES.Include(Function(e) e.ESTABLECIMIENTO)
            Return View(eNTRENADORES.ToList())
        End Function

        ' GET: ENTRENADORES/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim eNTRENADORES As ENTRENADORES = db.ENTRENADORES.Find(id)
            If IsNothing(eNTRENADORES) Then
                Return HttpNotFound()
            End If
            Return View(eNTRENADORES)
        End Function

        ' GET: ENTRENADORES/Create
        Function Create() As ActionResult
            ViewBag.EST_ID = New SelectList(db.ESTABLECIMIENTO, "EST_ID", "EST_NOMBRE")
            Return View()
        End Function

        ' POST: ENTRENADORES/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="EST_ID,ENT_ID,ENT_NOMBRE,ENT_APELLIDO,ENT_TELEFONO,ENT_EMAIL,ENT_DIRECCION,ENT_SUELDO")> ByVal eNTRENADORES As ENTRENADORES) As ActionResult
            If ModelState.IsValid Then
                db.ENTRENADORES.Add(eNTRENADORES)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EST_ID = New SelectList(db.ESTABLECIMIENTO, "EST_ID", "EST_NOMBRE", eNTRENADORES.EST_ID)
            Return View(eNTRENADORES)
        End Function

        ' GET: ENTRENADORES/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim eNTRENADORES As ENTRENADORES = db.ENTRENADORES.Find(id)
            If IsNothing(eNTRENADORES) Then
                Return HttpNotFound()
            End If
            ViewBag.EST_ID = New SelectList(db.ESTABLECIMIENTO, "EST_ID", "EST_NOMBRE", eNTRENADORES.EST_ID)
            Return View(eNTRENADORES)
        End Function

        ' POST: ENTRENADORES/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="EST_ID,ENT_ID,ENT_NOMBRE,ENT_APELLIDO,ENT_TELEFONO,ENT_EMAIL,ENT_DIRECCION,ENT_SUELDO")> ByVal eNTRENADORES As ENTRENADORES) As ActionResult
            If ModelState.IsValid Then
                db.Entry(eNTRENADORES).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EST_ID = New SelectList(db.ESTABLECIMIENTO, "EST_ID", "EST_NOMBRE", eNTRENADORES.EST_ID)
            Return View(eNTRENADORES)
        End Function

        ' GET: ENTRENADORES/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim eNTRENADORES As ENTRENADORES = db.ENTRENADORES.Find(id)
            If IsNothing(eNTRENADORES) Then
                Return HttpNotFound()
            End If
            Return View(eNTRENADORES)
        End Function

        ' POST: ENTRENADORES/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim eNTRENADORES As ENTRENADORES = db.ENTRENADORES.Find(id)
            db.ENTRENADORES.Remove(eNTRENADORES)
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
