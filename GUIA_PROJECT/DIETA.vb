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

Partial Public Class DIETA
    Public Property DIE_ID As Integer
    Public Property NOMBRE_DIETA As String

    Public Overridable Property COMIDA As ICollection(Of COMIDA) = New HashSet(Of COMIDA)
    Public Overridable Property ENTRENAMIENTO As ICollection(Of ENTRENAMIENTO) = New HashSet(Of ENTRENAMIENTO)

End Class
