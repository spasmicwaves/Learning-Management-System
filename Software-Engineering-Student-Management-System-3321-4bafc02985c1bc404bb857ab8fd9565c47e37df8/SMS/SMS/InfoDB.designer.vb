﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="InfoDB")>  _
Partial Public Class InfoDBDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertUsers(instance As Users)
    End Sub
  Partial Private Sub UpdateUsers(instance As Users)
    End Sub
  Partial Private Sub DeleteUsers(instance As Users)
    End Sub
  Partial Private Sub InsertProfessor(instance As Professor)
    End Sub
  Partial Private Sub UpdateProfessor(instance As Professor)
    End Sub
  Partial Private Sub DeleteProfessor(instance As Professor)
    End Sub
  Partial Private Sub InsertStudents(instance As Students)
    End Sub
  Partial Private Sub UpdateStudents(instance As Students)
    End Sub
  Partial Private Sub DeleteStudents(instance As Students)
    End Sub
  Partial Private Sub InsertCourse(instance As Course)
    End Sub
  Partial Private Sub UpdateCourse(instance As Course)
    End Sub
  Partial Private Sub DeleteCourse(instance As Course)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.SMS.My.MySettings.Default.InfoDBConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Users() As System.Data.Linq.Table(Of Users)
		Get
			Return Me.GetTable(Of Users)
		End Get
	End Property
	
	Public ReadOnly Property Professors() As System.Data.Linq.Table(Of Professor)
		Get
			Return Me.GetTable(Of Professor)
		End Get
	End Property
	
	Public ReadOnly Property Students() As System.Data.Linq.Table(Of Students)
		Get
			Return Me.GetTable(Of Students)
		End Get
	End Property
	
	Public ReadOnly Property Courses() As System.Data.Linq.Table(Of Course)
		Get
			Return Me.GetTable(Of Course)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.[Users]")>  _
Partial Public Class Users
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As Integer
	
	Private _Username As String
	
	Private _Password As String
	
	Private __Full_Name_ As String
	
	Private _Picture As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnUsernameChanging(value As String)
    End Sub
    Partial Private Sub OnUsernameChanged()
    End Sub
    Partial Private Sub OnPasswordChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordChanged()
    End Sub
    Partial Private Sub On_Full_Name_Changing(value As String)
    End Sub
    Partial Private Sub On_Full_Name_Changed()
    End Sub
    Partial Private Sub OnPictureChanging(value As String)
    End Sub
    Partial Private Sub OnPictureChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Username", DbType:="NVarChar(50)")>  _
	Public Property Username() As String
		Get
			Return Me._Username
		End Get
		Set
			If (String.Equals(Me._Username, value) = false) Then
				Me.OnUsernameChanging(value)
				Me.SendPropertyChanging
				Me._Username = value
				Me.SendPropertyChanged("Username")
				Me.OnUsernameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Password", DbType:="NVarChar(50)")>  _
	Public Property Password() As String
		Get
			Return Me._Password
		End Get
		Set
			If (String.Equals(Me._Password, value) = false) Then
				Me.OnPasswordChanging(value)
				Me.SendPropertyChanging
				Me._Password = value
				Me.SendPropertyChanged("Password")
				Me.OnPasswordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[[Full Name]]]", Storage:="__Full_Name_", DbType:="NVarChar(50)")>  _
	Public Property _Full_Name_() As String
		Get
			Return Me.__Full_Name_
		End Get
		Set
			If (String.Equals(Me.__Full_Name_, value) = false) Then
				Me.On_Full_Name_Changing(value)
				Me.SendPropertyChanging
				Me.__Full_Name_ = value
				Me.SendPropertyChanged("_Full_Name_")
				Me.On_Full_Name_Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Picture", DbType:="NVarChar(50)")>  _
	Public Property Picture() As String
		Get
			Return Me._Picture
		End Get
		Set
			If (String.Equals(Me._Picture, value) = false) Then
				Me.OnPictureChanging(value)
				Me.SendPropertyChanging
				Me._Picture = value
				Me.SendPropertyChanged("Picture")
				Me.OnPictureChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Professors")>  _
Partial Public Class Professor
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As Integer
	
	Private __Professor_ID_ As String
	
	Private __Professor_Name_ As String
	
	Private _Gender As String
	
	Private _Age As System.Nullable(Of Decimal)
	
	Private _Department As String
	
	Private _Picture As String
	
	Private _Address As String
	
	Private __Phone_Number_ As String
	
	Private __Email_ As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub On_Professor_ID_Changing(value As String)
    End Sub
    Partial Private Sub On_Professor_ID_Changed()
    End Sub
    Partial Private Sub On_Professor_Name_Changing(value As String)
    End Sub
    Partial Private Sub On_Professor_Name_Changed()
    End Sub
    Partial Private Sub OnGenderChanging(value As String)
    End Sub
    Partial Private Sub OnGenderChanged()
    End Sub
    Partial Private Sub OnAgeChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnAgeChanged()
    End Sub
    Partial Private Sub OnDepartmentChanging(value As String)
    End Sub
    Partial Private Sub OnDepartmentChanged()
    End Sub
    Partial Private Sub OnPictureChanging(value As String)
    End Sub
    Partial Private Sub OnPictureChanged()
    End Sub
    Partial Private Sub OnAddressChanging(value As String)
    End Sub
    Partial Private Sub OnAddressChanged()
    End Sub
    Partial Private Sub On_Phone_Number_Changing(value As String)
    End Sub
    Partial Private Sub On_Phone_Number_Changed()
    End Sub
    Partial Private Sub On_Email_Changing(value As String)
    End Sub
    Partial Private Sub On_Email_Changed()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[[Professor ID]]]", Storage:="__Professor_ID_", DbType:="NVarChar(50)")>  _
	Public Property _Professor_ID_() As String
		Get
			Return Me.__Professor_ID_
		End Get
		Set
			If (String.Equals(Me.__Professor_ID_, value) = false) Then
				Me.On_Professor_ID_Changing(value)
				Me.SendPropertyChanging
				Me.__Professor_ID_ = value
				Me.SendPropertyChanged("_Professor_ID_")
				Me.On_Professor_ID_Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[[Professor Name]]]", Storage:="__Professor_Name_", DbType:="NVarChar(50)")>  _
	Public Property _Professor_Name_() As String
		Get
			Return Me.__Professor_Name_
		End Get
		Set
			If (String.Equals(Me.__Professor_Name_, value) = false) Then
				Me.On_Professor_Name_Changing(value)
				Me.SendPropertyChanging
				Me.__Professor_Name_ = value
				Me.SendPropertyChanged("_Professor_Name_")
				Me.On_Professor_Name_Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Gender", DbType:="NVarChar(50)")>  _
	Public Property Gender() As String
		Get
			Return Me._Gender
		End Get
		Set
			If (String.Equals(Me._Gender, value) = false) Then
				Me.OnGenderChanging(value)
				Me.SendPropertyChanging
				Me._Gender = value
				Me.SendPropertyChanged("Gender")
				Me.OnGenderChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Age", DbType:="Decimal(18,0)")>  _
	Public Property Age() As System.Nullable(Of Decimal)
		Get
			Return Me._Age
		End Get
		Set
			If (Me._Age.Equals(value) = false) Then
				Me.OnAgeChanging(value)
				Me.SendPropertyChanging
				Me._Age = value
				Me.SendPropertyChanged("Age")
				Me.OnAgeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Department", DbType:="NVarChar(50)")>  _
	Public Property Department() As String
		Get
			Return Me._Department
		End Get
		Set
			If (String.Equals(Me._Department, value) = false) Then
				Me.OnDepartmentChanging(value)
				Me.SendPropertyChanging
				Me._Department = value
				Me.SendPropertyChanged("Department")
				Me.OnDepartmentChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Picture", DbType:="NVarChar(500)")>  _
	Public Property Picture() As String
		Get
			Return Me._Picture
		End Get
		Set
			If (String.Equals(Me._Picture, value) = false) Then
				Me.OnPictureChanging(value)
				Me.SendPropertyChanging
				Me._Picture = value
				Me.SendPropertyChanged("Picture")
				Me.OnPictureChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="NVarChar(MAX)")>  _
	Public Property Address() As String
		Get
			Return Me._Address
		End Get
		Set
			If (String.Equals(Me._Address, value) = false) Then
				Me.OnAddressChanging(value)
				Me.SendPropertyChanging
				Me._Address = value
				Me.SendPropertyChanged("Address")
				Me.OnAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[[Phone Number]]]", Storage:="__Phone_Number_", DbType:="NVarChar(50)")>  _
	Public Property _Phone_Number_() As String
		Get
			Return Me.__Phone_Number_
		End Get
		Set
			If (String.Equals(Me.__Phone_Number_, value) = false) Then
				Me.On_Phone_Number_Changing(value)
				Me.SendPropertyChanging
				Me.__Phone_Number_ = value
				Me.SendPropertyChanged("_Phone_Number_")
				Me.On_Phone_Number_Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[[Email]]]", Storage:="__Email_", DbType:="NVarChar(500)")>  _
	Public Property _Email_() As String
		Get
			Return Me.__Email_
		End Get
		Set
			If (String.Equals(Me.__Email_, value) = false) Then
				Me.On_Email_Changing(value)
				Me.SendPropertyChanging
				Me.__Email_ = value
				Me.SendPropertyChanged("_Email_")
				Me.On_Email_Changed
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Students")>  _
Partial Public Class Students
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _STUDENTINF As Integer
	
	Private _StudentName As String
	
	Private _Gender As String
	
	Private _Age As System.Nullable(Of Decimal)
	
	Private _Address As String
	
	Private _ContactNumber As String
	
	Private _StudentID As String
	
	Private _EmailAddress As String
	
	Private _Class As String
	
	Private _Stream As String
	
	Private _StudentPicture As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnSTUDENTINFChanging(value As Integer)
    End Sub
    Partial Private Sub OnSTUDENTINFChanged()
    End Sub
    Partial Private Sub OnStudentNameChanging(value As String)
    End Sub
    Partial Private Sub OnStudentNameChanged()
    End Sub
    Partial Private Sub OnGenderChanging(value As String)
    End Sub
    Partial Private Sub OnGenderChanged()
    End Sub
    Partial Private Sub OnAgeChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnAgeChanged()
    End Sub
    Partial Private Sub OnAddressChanging(value As String)
    End Sub
    Partial Private Sub OnAddressChanged()
    End Sub
    Partial Private Sub OnContactNumberChanging(value As String)
    End Sub
    Partial Private Sub OnContactNumberChanged()
    End Sub
    Partial Private Sub OnStudentIDChanging(value As String)
    End Sub
    Partial Private Sub OnStudentIDChanged()
    End Sub
    Partial Private Sub OnEmailAddressChanging(value As String)
    End Sub
    Partial Private Sub OnEmailAddressChanged()
    End Sub
    Partial Private Sub OnClassChanging(value As String)
    End Sub
    Partial Private Sub OnClassChanged()
    End Sub
    Partial Private Sub OnStreamChanging(value As String)
    End Sub
    Partial Private Sub OnStreamChanged()
    End Sub
    Partial Private Sub OnStudentPictureChanging(value As String)
    End Sub
    Partial Private Sub OnStudentPictureChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_STUDENTINF", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property STUDENTINF() As Integer
		Get
			Return Me._STUDENTINF
		End Get
		Set
			If ((Me._STUDENTINF = value)  _
						= false) Then
				Me.OnSTUDENTINFChanging(value)
				Me.SendPropertyChanging
				Me._STUDENTINF = value
				Me.SendPropertyChanged("STUDENTINF")
				Me.OnSTUDENTINFChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StudentName", DbType:="NVarChar(50)")>  _
	Public Property StudentName() As String
		Get
			Return Me._StudentName
		End Get
		Set
			If (String.Equals(Me._StudentName, value) = false) Then
				Me.OnStudentNameChanging(value)
				Me.SendPropertyChanging
				Me._StudentName = value
				Me.SendPropertyChanged("StudentName")
				Me.OnStudentNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Gender", DbType:="NVarChar(50)")>  _
	Public Property Gender() As String
		Get
			Return Me._Gender
		End Get
		Set
			If (String.Equals(Me._Gender, value) = false) Then
				Me.OnGenderChanging(value)
				Me.SendPropertyChanging
				Me._Gender = value
				Me.SendPropertyChanged("Gender")
				Me.OnGenderChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Age", DbType:="Decimal(18,0)")>  _
	Public Property Age() As System.Nullable(Of Decimal)
		Get
			Return Me._Age
		End Get
		Set
			If (Me._Age.Equals(value) = false) Then
				Me.OnAgeChanging(value)
				Me.SendPropertyChanging
				Me._Age = value
				Me.SendPropertyChanged("Age")
				Me.OnAgeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="NVarChar(MAX)")>  _
	Public Property Address() As String
		Get
			Return Me._Address
		End Get
		Set
			If (String.Equals(Me._Address, value) = false) Then
				Me.OnAddressChanging(value)
				Me.SendPropertyChanging
				Me._Address = value
				Me.SendPropertyChanged("Address")
				Me.OnAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ContactNumber", DbType:="NVarChar(50)")>  _
	Public Property ContactNumber() As String
		Get
			Return Me._ContactNumber
		End Get
		Set
			If (String.Equals(Me._ContactNumber, value) = false) Then
				Me.OnContactNumberChanging(value)
				Me.SendPropertyChanging
				Me._ContactNumber = value
				Me.SendPropertyChanged("ContactNumber")
				Me.OnContactNumberChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StudentID", DbType:="NVarChar(50)")>  _
	Public Property StudentID() As String
		Get
			Return Me._StudentID
		End Get
		Set
			If (String.Equals(Me._StudentID, value) = false) Then
				Me.OnStudentIDChanging(value)
				Me.SendPropertyChanging
				Me._StudentID = value
				Me.SendPropertyChanged("StudentID")
				Me.OnStudentIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EmailAddress", DbType:="NVarChar(500)")>  _
	Public Property EmailAddress() As String
		Get
			Return Me._EmailAddress
		End Get
		Set
			If (String.Equals(Me._EmailAddress, value) = false) Then
				Me.OnEmailAddressChanging(value)
				Me.SendPropertyChanging
				Me._EmailAddress = value
				Me.SendPropertyChanged("EmailAddress")
				Me.OnEmailAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Class", Storage:="_Class", DbType:="NVarChar(50)")>  _
	Public Property [Class]() As String
		Get
			Return Me._Class
		End Get
		Set
			If (String.Equals(Me._Class, value) = false) Then
				Me.OnClassChanging(value)
				Me.SendPropertyChanging
				Me._Class = value
				Me.SendPropertyChanged("[Class]")
				Me.OnClassChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Stream", DbType:="NVarChar(50)")>  _
	Public Property Stream() As String
		Get
			Return Me._Stream
		End Get
		Set
			If (String.Equals(Me._Stream, value) = false) Then
				Me.OnStreamChanging(value)
				Me.SendPropertyChanging
				Me._Stream = value
				Me.SendPropertyChanged("Stream")
				Me.OnStreamChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StudentPicture", DbType:="NVarChar(500)")>  _
	Public Property StudentPicture() As String
		Get
			Return Me._StudentPicture
		End Get
		Set
			If (String.Equals(Me._StudentPicture, value) = false) Then
				Me.OnStudentPictureChanging(value)
				Me.SendPropertyChanging
				Me._StudentPicture = value
				Me.SendPropertyChanged("StudentPicture")
				Me.OnStudentPictureChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Courses")>  _
Partial Public Class Course
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As Integer
	
	Private _StudentID As String
	
	Private _StudentName As String
	
	Private _Class As String
	
	Private _Course As String
	
	Private _Exam As System.Nullable(Of Decimal)
	
	Private _Overall As System.Nullable(Of Decimal)
	
	Private _GPA As System.Nullable(Of Decimal)
	
	Private _Grade As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnStudentIDChanging(value As String)
    End Sub
    Partial Private Sub OnStudentIDChanged()
    End Sub
    Partial Private Sub OnStudentNameChanging(value As String)
    End Sub
    Partial Private Sub OnStudentNameChanged()
    End Sub
    Partial Private Sub OnClassChanging(value As String)
    End Sub
    Partial Private Sub OnClassChanged()
    End Sub
    Partial Private Sub OnCourseChanging(value As String)
    End Sub
    Partial Private Sub OnCourseChanged()
    End Sub
    Partial Private Sub OnExamChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnExamChanged()
    End Sub
    Partial Private Sub OnOverallChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnOverallChanged()
    End Sub
    Partial Private Sub OnGPAChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnGPAChanged()
    End Sub
    Partial Private Sub OnGradeChanging(value As String)
    End Sub
    Partial Private Sub OnGradeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StudentID", DbType:="NVarChar(50)")>  _
	Public Property StudentID() As String
		Get
			Return Me._StudentID
		End Get
		Set
			If (String.Equals(Me._StudentID, value) = false) Then
				Me.OnStudentIDChanging(value)
				Me.SendPropertyChanging
				Me._StudentID = value
				Me.SendPropertyChanged("StudentID")
				Me.OnStudentIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StudentName", DbType:="NVarChar(50)")>  _
	Public Property StudentName() As String
		Get
			Return Me._StudentName
		End Get
		Set
			If (String.Equals(Me._StudentName, value) = false) Then
				Me.OnStudentNameChanging(value)
				Me.SendPropertyChanging
				Me._StudentName = value
				Me.SendPropertyChanged("StudentName")
				Me.OnStudentNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Class", Storage:="_Class", DbType:="NVarChar(50)")>  _
	Public Property [Class]() As String
		Get
			Return Me._Class
		End Get
		Set
			If (String.Equals(Me._Class, value) = false) Then
				Me.OnClassChanging(value)
				Me.SendPropertyChanging
				Me._Class = value
				Me.SendPropertyChanged("[Class]")
				Me.OnClassChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Course", DbType:="NChar(10)")>  _
	Public Property Course() As String
		Get
			Return Me._Course
		End Get
		Set
			If (String.Equals(Me._Course, value) = false) Then
				Me.OnCourseChanging(value)
				Me.SendPropertyChanging
				Me._Course = value
				Me.SendPropertyChanged("Course")
				Me.OnCourseChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Exam", DbType:="Decimal(18,0)")>  _
	Public Property Exam() As System.Nullable(Of Decimal)
		Get
			Return Me._Exam
		End Get
		Set
			If (Me._Exam.Equals(value) = false) Then
				Me.OnExamChanging(value)
				Me.SendPropertyChanging
				Me._Exam = value
				Me.SendPropertyChanged("Exam")
				Me.OnExamChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Overall", DbType:="Decimal(18,0)")>  _
	Public Property Overall() As System.Nullable(Of Decimal)
		Get
			Return Me._Overall
		End Get
		Set
			If (Me._Overall.Equals(value) = false) Then
				Me.OnOverallChanging(value)
				Me.SendPropertyChanging
				Me._Overall = value
				Me.SendPropertyChanged("Overall")
				Me.OnOverallChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_GPA", DbType:="Decimal(18,0)")>  _
	Public Property GPA() As System.Nullable(Of Decimal)
		Get
			Return Me._GPA
		End Get
		Set
			If (Me._GPA.Equals(value) = false) Then
				Me.OnGPAChanging(value)
				Me.SendPropertyChanging
				Me._GPA = value
				Me.SendPropertyChanged("GPA")
				Me.OnGPAChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Grade", DbType:="NVarChar(50)")>  _
	Public Property Grade() As String
		Get
			Return Me._Grade
		End Get
		Set
			If (String.Equals(Me._Grade, value) = false) Then
				Me.OnGradeChanging(value)
				Me.SendPropertyChanging
				Me._Grade = value
				Me.SendPropertyChanged("Grade")
				Me.OnGradeChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
