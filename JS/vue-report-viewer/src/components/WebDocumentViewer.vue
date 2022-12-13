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
        reportUrl: ko.observable("TestReport"),
        requestOptions: {
        host: "https://localhost:54114/",
        invokeAction: "DXXRDV"
        }
    };
    ko.applyBindings(viewerOptions, this.$refs.viewer);
},
beforeDestroy() {
    ko.cleanNode(this.$refs.viewer);
}
};
</script>
