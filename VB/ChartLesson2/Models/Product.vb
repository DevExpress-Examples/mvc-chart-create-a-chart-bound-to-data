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

    Partial Public Class Product
        Public Property ProductID() As Integer
        Public Property ProductName() As String
        Public Property SupplierID() As Integer?
        Public Property CategoryID() As Integer?
        Public Property QuantityPerUnit() As String
        Public Property UnitPrice() As Decimal?
        Public Property UnitsInStock() As Short?
        Public Property UnitsOnOrder() As Short?
        Public Property ReorderLevel() As Short?
        Public Property Discontinued() As Boolean
        Public Property EAN13() As String

        Public Overridable Property Category() As Category
    End Class
End Namespace