var config;

jsLib.dom.ready( function () {
    config = new ConfigForm();
    
    var processorClick = function () {
        config.processorClick();
    }
    var opticalChange = function () {
        config.opticalChange();
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
        
    jsLib.event.add( $("optical0"), "change", opticalChange );
    jsLib.event.add( $("optical1"), "change", opticalChange );        

    jsLib.event.add( $("config_reset"), "click", formReset );
    jsLib.event.add( $("product_form"), "submit", formSubmit );
});