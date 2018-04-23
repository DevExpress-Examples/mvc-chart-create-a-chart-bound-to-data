﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/jquery-1.10.2.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
    <script src="~/Scripts/modernizr-2.6.2.js"></script>
    @Html.DevExpress().GetScripts(
                        New Script With {.ExtensionSuite = ExtensionSuite.Chart}
                )
    @Html.DevExpress().GetStyleSheets(
                    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Chart}
                )

</head>%
<body>
    <div class="container body-content">
        @RenderBody()
    </div>
</body>
</html>
