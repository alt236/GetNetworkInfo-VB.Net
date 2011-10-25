Imports System.Reflection
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text


Public Class frmAbout
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim currentAssembly As Assembly = Assembly.GetExecutingAssembly()
        Dim dictionaryOfProperties As Dictionary(Of String, String) = GetAssemblyInfoDictionary(currentAssembly)

        lblName.Text = dictionaryOfProperties("AssemblyName")
        lblVersion.Text = "v" & dictionaryOfProperties("Version")
        lblCopyright.Text = dictionaryOfProperties("Copyright")

        fldAck.Text = My.Resources.acknowledgements
        fldChange.Text = My.Resources.changelog
        fldNotes.Text = My.Resources.notes

        If Trim(fldAck.Text).Length = 0 Then TabControl1.TabPages.RemoveAt(TabControl1.TabPages.IndexOf(tpAcknowledgements))
        If Trim(fldChange.Text).Length = 0 Then TabControl1.TabPages.RemoveAt(TabControl1.TabPages.IndexOf(tpChangelog))
        If Trim(fldNotes.Text).Length = 0 Then TabControl1.TabPages.RemoveAt(TabControl1.TabPages.IndexOf(tpNotes))

        TabControl1.SelectedIndex = 0

    End Sub

    ''' <summary> 
    ''' A method that returns a Dictionary of Assembly properties 
    ''' </summary> 
    ''' <param name="selectedAssembly">The assembly to inspect</param> 
    ''' <returns>The dictrionary containing the assembly information</returns> 
    Public Function GetAssemblyInfoDictionary(ByVal selectedAssembly As Assembly) As Dictionary(Of String, String)
        'Create the dictionary 
        Dim dictionaryOfProperties As New Dictionary(Of String, String)()

        'get the location of the assembly 
        'Dim assemblyPath As String = selectedAssembly.Location

        'add the assembly location to out dictionary 
        'dictionaryOfProperties.Add("AssemblyLocation", assemblyPath)

        'create the AssemblyName object based on our Assembly 
        'this will enable us to get the version information 
        'and other properties related to our assembly 
        Dim assemblyName As Reflection.AssemblyName = selectedAssembly.GetName()

        'add the FullName of our assembly 
        dictionaryOfProperties.Add("AssemblyFullName", assemblyName.FullName)
        'add the Name of the assembly
        dictionaryOfProperties.Add("AssemblyName", assemblyName.Name)

        'add the assembly version information 
        dictionaryOfProperties.Add("Version", assemblyName.Version.ToString())
        dictionaryOfProperties.Add("Version.Major", assemblyName.Version.Major.ToString())
        dictionaryOfProperties.Add("Version.Minor", assemblyName.Version.Minor.ToString())
        dictionaryOfProperties.Add("Version.Build", assemblyName.Version.Build.ToString())
        dictionaryOfProperties.Add("Version.Revision", assemblyName.Version.Revision.ToString())

        'Get the Copyright info.
        'Get the Copyright info.
        Dim copyrightInstance As AssemblyCopyrightAttribute = CType(AssemblyCopyrightAttribute.GetCustomAttribute(System.Reflection.Assembly.GetExecutingAssembly, GetType(AssemblyCopyrightAttribute)), AssemblyCopyrightAttribute)
        dictionaryOfProperties.Add("Copyright", copyrightInstance.Copyright)

        'add the creation time 
        'Dim creationTime As DateTime = File.GetCreationTime(assemblyPath)
        'dictionaryOfProperties.Add("CreationTime", creationTime.ToString())

        'add the last write time 
        'Dim lastWriteTime As DateTime = File.GetLastWriteTime(assemblyPath)
        'dictionaryOfProperties.Add("LastWriteTime", creationTime.ToString())

        'return our dictionary obeject 
        Return dictionaryOfProperties
    End Function
End Class