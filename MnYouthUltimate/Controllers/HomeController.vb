<HandleError()> _
Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Welcome to the new web presence of the Minnesota Youth Ultimate League."

        Return View()
    End Function

    Function About() As ActionResult
        Return View()
    End Function
End Class
