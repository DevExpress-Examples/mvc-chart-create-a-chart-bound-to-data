﻿Imports System.Collections.Generic
Imports System

'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace ChartLesson2.Models

    Partial Public Class Category
        Public Sub New()
            Me.Products = New HashSet(Of Product)()
        End Sub

        Public Property CategoryID() As Integer
        Public Property CategoryName() As String
        Public Property Description() As String
        Public Property Picture() As Byte()

        Public Overridable Property Products() As ICollection(Of Product)
    End Class
End Namespace
