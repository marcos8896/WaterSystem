Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Module Module1

    'Dim conexionsql As New SqlConnection("Data Source='MARCOS-LAPTOP\PLEASEWORK'; Initial Catalog='Sistema'; integrated security=true")
    'Dim conexionsql As New SqlConnection("Data Source='MARCOS-LAPTOP\PLEASEWORK'; Initial Catalog='Sistema'; User Id=sa; password='abc'")

    Public Function stringConnection() As String
        Return "Data Source='MARCOS-PC'; Initial Catalog='db_agua_potable'; Integrated security=true" 'PC
        'Return "Data Source='MARCOS-LAPTOP\PLEASEWORK'; Initial Catalog='db_agua_potable'; Integrated security=true" 'LAPTOP


    End Function

    Public Sub caracteresValidos(sender As Object, e As KeyPressEventArgs, opcion As String)
        If opcion.Equals("ALL") Then
            Dim CadenaValida As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚ0123456789.,;#- "
            e.KeyChar = UCase(e.KeyChar)
            If e.KeyChar > ChrW(26) Then
                If InStr(CadenaValida, e.KeyChar) = 0 Then
                    e.KeyChar = ChrW(0)
                End If
            End If
        End If

        If opcion.Equals("NUMBERS") Then
            Dim CadenaValida As String = "0123456789."
            e.KeyChar = UCase(e.KeyChar)
            If e.KeyChar > ChrW(26) Then
                If InStr(CadenaValida, e.KeyChar) = 0 Then
                    e.KeyChar = ChrW(0)
                End If
            End If
        End If

        If opcion.Equals("LETTERS") Then
            Dim CadenaValida As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚ.,;#- "
            e.KeyChar = UCase(e.KeyChar)
            If e.KeyChar > ChrW(26) Then
                If InStr(CadenaValida, e.KeyChar) = 0 Then
                    e.KeyChar = ChrW(0)
                End If
            End If
        End If

        If opcion.Equals("LETTERS_ONLY") Then
            Dim CadenaValida As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZÁÉÍÓÚ "
            e.KeyChar = UCase(e.KeyChar)
            If e.KeyChar > ChrW(26) Then
                If InStr(CadenaValida, e.KeyChar) = 0 Then
                    e.KeyChar = ChrW(0)
                End If
            End If
        End If

        If opcion.Equals("NUMBERS_NO_DOT") Then
            Dim CadenaValida As String = "0123456789"
            e.KeyChar = UCase(e.KeyChar)
            If e.KeyChar > ChrW(26) Then
                If InStr(CadenaValida, e.KeyChar) = 0 Then
                    e.KeyChar = ChrW(0)
                End If
            End If
        End If

    End Sub

    Public Sub puntoAcoma(sender As Object, e As KeyPressEventArgs)
        Dim CadenaValida As String = ".,;#- "
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar > ChrW(26) Then
            If InStr(CadenaValida, e.KeyChar) = 0 Then
                e.KeyChar = ChrW(0)
            End If
        End If
    End Sub

End Module
