' HINWEIS: Mit dem Befehl "Umbenennen" im Kontextmenü können Sie den Klassennamen "Service1" sowohl im Code als auch in der SVC-Datei und der Konfigurationsdatei ändern.
Public Class Service1
    Implements IService1

    Public Sub New()
    End Sub

    Public Function GetData(ByVal value As String) As String Implements IService1.GetData
        Return String.Format("You entered: {0}", value)
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IService1.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

    Public Function GetPicture(ByVal Source As String) As Object Implements IService1.GetPicture
        Try
            Process.Start(Source)        'Db holt man sich nun über die Source das Bild und gibts es zurück
            Return "true"
        Catch ex As Exception
            Return "false"
        End Try
      
    End Function
End Class
