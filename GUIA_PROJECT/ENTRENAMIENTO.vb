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

Partial Public Class ENTRENAMIENTO
    Public Property ENT_ID As Integer
    Public Property CLI_ID As Integer
    Public Property EJER_ID As Nullable(Of Integer)
    Public Property DIE_ID As Nullable(Of Integer)
    Public Property FECHA As Nullable(Of Date)

    Public Overridable Property CLIENTE As CLIENTE
    Public Overridable Property DIETA As DIETA
    Public Overridable Property EJERCICIO As EJERCICIO
    Public Overridable Property ENTRENADORES As ENTRENADORES

End Class
