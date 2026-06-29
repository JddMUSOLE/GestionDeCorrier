Imports System
Imports System.Data
Imports System.Data.SqlClient
Module connexion
    Dim ChaineCon As String = "SERVER=JDD\SQL1; DATABASE=CourrierBDD; USER ID=CourrierDRH; PASSWORD=1111"
    Public con As New SqlConnection(ChaineCon)
    Public typeDocument As String = "0001"
    Public typeDocumentSortant As String = "0002"
    Public typeDocumentOS As String = "0003"
    Public typeDocumentIS As String = "0004"
    Public userMat As String
    Public codeOrganeExp As String
    Public codeOrganeDest As String
    Public CodeService As String
    Public CodeServiceExp As String
    Public CodeServiceDest As String
    Public AutoriteSign As String
    Public concerne As String
    Public NumDocc As String
    Public RefDoc As String
    Public DateDocument As String
    Public DateRecept As String
    Public DateExped As String
    Public Etat As String
    Public Annexe As String
    Public annotation As String
    Public CodeEtatCharge As String
    Public SceOrienter As String

End Module
