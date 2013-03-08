'
' DotNetNuke� - http://www.dotnetnuke.com
' Copyright (c) 2002-2012
' by DotNetNuke Corporation
'
' Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
' documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
' the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
' to permit persons to whom the Software is furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in all copies or substantial portions 
' of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
' DEALINGS IN THE SOFTWARE.
'
Imports DotNetNuke.Modules.Blog.Providers.Data
Imports DotNetNuke.Modules.Blog.Business
Imports DotNetNuke.Common.Utilities

Namespace Controllers

 Public Class ArchiveController

  ''' <summary>
  ''' 
  ''' </summary>
  ''' <param name="PortalID"></param>
  ''' <param name="BlogID"></param>
  ''' <returns></returns>
  ''' <remarks>CP: Changed to generic lists instead of ArrayList</remarks>
  Public Shared Function GetBlogMonths(PortalID As Integer, BlogID As Integer) As List(Of ArchiveMonths)
   Return CBO.FillCollection(Of ArchiveMonths)(DataProvider.Instance().GetBlogMonths(PortalID, BlogID))
  End Function

  Public Shared Function GetBlogDaysForMonth(PortalID As Integer, BlogID As Integer, BlogDate As Date) As List(Of ArchiveDays)
   Return CBO.FillCollection(Of ArchiveDays)(DataProvider.Instance().GetBlogDaysForMonth(PortalID, BlogID, BlogDate))
  End Function

 End Class

End Namespace