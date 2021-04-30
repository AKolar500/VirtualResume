var config;

jsLib.dom.ready( function () {
    config = new ConfigForm();
    
    var processorClick = function () {
        config.processorClick();
    }
    var memoryClick = function () {
        config.memoryClick();
    }
    var osClick = function () {
        config.osClick();
    }
    var opticalChange = function () {
        config.opticalChange();
    }
    var hdChange = function () {
        config.hdChange();
    }
    var displayChange = function () {
        config.displayChange();
    }
    var formReset = function () {
        $("product_form").reset();
        config.reset();
    }
    var formSubmit = function (evt) {
        var error = config.validateAll();
        if (error) {
            alert("Please fix the errors before placing order.");
            evt.preventDefault();
        }
    }
    
    jsLib.event.add( $("proc0"), "click", processorClick );
    jsLib.event.add( $("proc1"), "click", processorClick );
    jsLib.event.add( $("proc2"), "click", processorClick );
    jsLib.event.add( $("proc3"), "click", processorClick );
        
    jsLib.event.add( $("mem0"), "click", memoryClick );
    jsLib.event.add( $("mem1"), "click", memoryClick );
    jsLib.event.add( $("mem2"), "click", memoryClick );
        
    jsLib.event.add( $("os0"), "click", osClick );
    jsLib.event.add( $("os1"), "click", osClick );
    jsLib.event.add( $("os2"), "click", osClick );
        
    jsLib.event.add( $("optical0"), "change", opticalChange );
    jsLib.event.add( $("optical1"), "change", opticalChange );
        
    jsLib.event.add( $("hd_num"),  "change", hdChange );
    jsLib.event.add( $("hd_size"), "change", hdChange );
    jsLib.event.add( $("hd_raid"), "change", hdChange );
    
    jsLib.event.add( $("display_num"),  "change", displayChange );
    jsLib.event.add( $("display_size"), "change", displayChange );

    jsLib.event.add( $("config_reset"), "click", formReset );
    jsLib.event.add( $("product_form"), "submit", formSubmit );
});