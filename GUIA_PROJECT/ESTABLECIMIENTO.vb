'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class ESTABLECIMIENTO
    Public Property EST_ID As Integer
    Public Property LOCAL_ID As Nullable(Of Integer)
    Public Property EST_NOMBRE As String
    Public Property EST_TELEFONO As String
    Public Property EST_FECHAINAGURACION As Nullable(Of Date)

    Public Overridable Property ADMINISTRADOR As ICollection(Of ADMINISTRADOR) = New HashSet(Of ADMINISTRADOR)
    Public Overridable Property CLIENTE As ICollection(Of CLIENTE) = New HashSet(Of CLIENTE)
    Public Overridable Property ENTRENADORES As ICollection(Of ENTRENADORES) = New HashSet(Of ENTRENADORES)
    Public Overridable Property LOCALIDAD As LOCALIDAD

End Class
