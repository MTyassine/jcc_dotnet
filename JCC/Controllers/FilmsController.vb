﻿Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports JCC.Data
Imports JCC.Domain.Entities

Namespace Controllers
    Public Class FilmsController
        Inherits System.Web.Mvc.Controller

        Private db As New JCCContext

        ' GET: Films
        Function Index() As ActionResult
            Return View(db.Films.ToList())
        End Function

        ' GET: Films/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim film As Film = db.Films.Find(id)
            If IsNothing(film) Then
                Return HttpNotFound()
            End If
            Return View(film)
        End Function

        ' GET: Films/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Films/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="FilmId,Nom,realisateur,origine")> ByVal film As Film) As ActionResult
            If ModelState.IsValid Then
                db.Films.Add(film)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(film)
        End Function

        ' GET: Films/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim film As Film = db.Films.Find(id)
            If IsNothing(film) Then
                Return HttpNotFound()
            End If
            Return View(film)
        End Function

        ' POST: Films/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="FilmId,Nom,realisateur,origine")> ByVal film As Film) As ActionResult
            If ModelState.IsValid Then
                db.Entry(film).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(film)
        End Function

        ' GET: Films/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim film As Film = db.Films.Find(id)
            If IsNothing(film) Then
                Return HttpNotFound()
            End If
            Return View(film)
        End Function

        ' POST: Films/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim film As Film = db.Films.Find(id)
            db.Films.Remove(film)
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
