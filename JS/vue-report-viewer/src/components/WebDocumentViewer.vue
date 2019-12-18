<template>
<div ref="viewer" style="position: absolute; left: 0; right: 0; top: 0; bottom: 0" data-bind="dxReportViewer: $data"></div>
</template>

<script>
import ko from "knockout";
import "devexpress-reporting/dx-webdocumentviewer";

export default {
name: "WebDocumentViewer",
mounted() {
    var viewerOptions = {
        reportUrl: ko.observable("Products"), // The URL of a report.
        requestOptions: {
        host: "http://localhost:54114/",
	// Use this line if you use an ASP.NET MVC backend
	invokeAction: "/WebDocumentViewer/Invoke"
	// Uncomment this line if you use an ASP.NET Core backend
	//invokeAction: "DXXRDV"
        }
    };
    ko.applyBindings(viewerOptions, this.$refs.viewer);
},
beforeDestroy() {
    ko.cleanNode(this.$refs.viewer);
}
};
</script>
