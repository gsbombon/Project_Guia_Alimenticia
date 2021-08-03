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
    Public Class TIPO_EJERCICIOController
        Inherits System.Web.Mvc.Controller

        Private db As New GUIA_ENTRENAMIENTOEntities

        ' GET: TIPO_EJERCICIO
        Function Index() As ActionResult
            Dim tIPO_EJERCICIO = db.TIPO_EJERCICIO.Include(Function(t) t.EJERCICIO)
            Return View(tIPO_EJERCICIO.ToList())
        End Function

        ' GET: TIPO_EJERCICIO/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tIPO_EJERCICIO As TIPO_EJERCICIO = db.TIPO_EJERCICIO.Find(id)
            If IsNothing(tIPO_EJERCICIO) Then
                Return HttpNotFound()
            End If
            Return View(tIPO_EJERCICIO)
        End Function

        ' GET: TIPO_EJERCICIO/Create
        Function Create() As ActionResult
            ViewBag.EJER_ID = New SelectList(db.EJERCICIO, "EJER_ID", "EJER_RUTINA")
            Return View()
        End Function

        ' POST: TIPO_EJERCICIO/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="EJER_ID,TIP_EJER_ID,EP_EJER_DESCRIPCION,CALORIAS_GASTADAS,ENFOQUE,ESTADO")> ByVal tIPO_EJERCICIO As TIPO_EJERCICIO) As ActionResult
            If ModelState.IsValid Then
                db.TIPO_EJERCICIO.Add(tIPO_EJERCICIO)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EJER_ID = New SelectList(db.EJERCICIO, "EJER_ID", "EJER_RUTINA", tIPO_EJERCICIO.EJER_ID)
            Return View(tIPO_EJERCICIO)
        End Function

        ' GET: TIPO_EJERCICIO/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tIPO_EJERCICIO As TIPO_EJERCICIO = db.TIPO_EJERCICIO.Find(id)
            If IsNothing(tIPO_EJERCICIO) Then
                Return HttpNotFound()
            End If
            ViewBag.EJER_ID = New SelectList(db.EJERCICIO, "EJER_ID", "EJER_RUTINA", tIPO_EJERCICIO.EJER_ID)
            Return View(tIPO_EJERCICIO)
        End Function

        ' POST: TIPO_EJERCICIO/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="EJER_ID,TIP_EJER_ID,EP_EJER_DESCRIPCION,CALORIAS_GASTADAS,ENFOQUE,ESTADO")> ByVal tIPO_EJERCICIO As TIPO_EJERCICIO) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tIPO_EJERCICIO).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.EJER_ID = New SelectList(db.EJERCICIO, "EJER_ID", "EJER_RUTINA", tIPO_EJERCICIO.EJER_ID)
            Return View(tIPO_EJERCICIO)
        End Function

        ' GET: TIPO_EJERCICIO/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tIPO_EJERCICIO As TIPO_EJERCICIO = db.TIPO_EJERCICIO.Find(id)
            If IsNothing(tIPO_EJERCICIO) Then
                Return HttpNotFound()
            End If
            Return View(tIPO_EJERCICIO)
        End Function

        ' POST: TIPO_EJERCICIO/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tIPO_EJERCICIO As TIPO_EJERCICIO = db.TIPO_EJERCICIO.Find(id)
            db.TIPO_EJERCICIO.Remove(tIPO_EJERCICIO)
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
