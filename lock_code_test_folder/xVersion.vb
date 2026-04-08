Public Module xVersion
    Public Const AssemblyCopyrightYear As String = "2026"
    Public Const MyAssemblyVersionCore As String = "$FUTURE_VERSION"
    Public Const ReleaseChannel As String = "alpha"
    Public Const IsStableReleaseChannel = ReleaseChannel = "stable"
    Public Const AssemblyCompany As String = "Cardknox Development, Inc."
End Module

Public Class VersionComparer
    Implements IComparer(Of String)

    Public Shared Property Comparer As New VersionComparer
