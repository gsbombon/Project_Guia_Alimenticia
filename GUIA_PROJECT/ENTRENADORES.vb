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

Partial Public Class ENTRENADORES
    Public Property EST_ID As Nullable(Of Integer)
    Public Property ENT_ID As Integer
    Public Property ENT_NOMBRE As String
    Public Property ENT_APELLIDO As String
    Public Property ENT_TELEFONO As String
    Public Property ENT_EMAIL As String
    Public Property ENT_DIRECCION As String
    Public Property ENT_SUELDO As Nullable(Of Double)

    Public Overridable Property ESTABLECIMIENTO As ESTABLECIMIENTO
    Public Overridable Property ENTRENAMIENTO As ICollection(Of ENTRENAMIENTO) = New HashSet(Of ENTRENAMIENTO)

End Class