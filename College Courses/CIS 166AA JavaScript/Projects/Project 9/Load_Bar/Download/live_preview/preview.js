
var myProgressBar = null;
var timerId = null;

var $ = function(id){
	return document.getElementById(id);
}

var itemList = {
	0 : {
		layoutIndex : 0,
		foregrounds : ['images/h_fg2.png', 'images/v_fg12.png', 'images/h_fg4.png', 'images/h_fg5.png', 'images/h_fg9.png', 'images/h_fg6.png', 'images/h_fg7.png'],
		backgrounds : ['images/h_bg1.png', 'images/marker8.png', 'images/h_bg2.png', 'images/h_bg3.png', 'images/h_bg4.png']
	},
	
	1 : {
		layoutIndex : 1,
		foregrounds : ['images/v_fg2.png', 'images/v_fg3.png', 'images/v_fg4.png', 'images/v_fg5.png', 'images/v_fg9.png', 'images/v_fg6.png', 'images/v_fg7.png'],
		backgrounds : ['images/v_bg1.png', 'images/v_bg2.png', 'images/v_bg3.png']
	},
	
	2 : {
		layoutIndex : 0,
		previewBackground : 'bg/bg5.jpg'
	},
	
	3 : {
		layoutIndex : 1,
		previewBackground : 'bg/bg5.jpg'
	},
	
	6 : {
		showAnimationStyles : true,
		showAnimationSpeed : true,
		markers : ['images/marker.png','images/marker2.png','images/marker3.png','images/marker4.png','images/marker5.png']
	},
	
	9 : {
		previewBackground : 'bg/bg5.jpg'
	},
	
	10 : {
		previewBackground : 'bg/bg1.jpg'
	},
	
	11 : {
		previewBackground : 'bg/bg7.jpg'
	},
	
	12 : {
		previewBackground : 'bg/bg1.jpg'
	},
	
	13 : {
		showAnimationSmoothness : true
	},
	
	14 : {
		previewBackground :'bg/bg100.gif'
	},
	
	15 : {
		previewBackground :'bg/bg5.jpg'
	},
	
	16 : {
		previewBackground :'bg/bg5.jpg'
	},
	
	18 : {
		previewBackground :'bg/bg7.jpg'
	}
};

var currentExampleId = 0;
function showExample(inx){
	window.location = '#' + 'usage_examples';
	showItem(inx);
	return false;
}
function showCode(){	
	var con = document.getElementById('preview_code_cont');
	var prv = document.getElementById('preview_code');
	
	var styleElement = document.getElementById("preview_styles");
	var divElement = document.getElementById("item_"+ currentExampleId);
	
	var funcCode = "";
	var divCode = "";
	var styleCode = "";
	
	var r = "", i = 1;
	
	eval("funcCode = example_"+ currentExampleId +".toString()");
	
	funcCode = funcCode.replace("example_"+ currentExampleId +"", "loadProgressBar");
	while (funcCode.indexOf("progressbar_"+ currentExampleId +"_"+ i) != -1){
		funcCode = funcCode.replace("progressbar_"+ currentExampleId +"_"+ i, "my_progress_bar_"+ i);
		if (funcCode.indexOf("progressbar_"+ currentExampleId +"_"+ i) == -1)
			i++;
	}
	
	while (funcCode.indexOf(", ") != -1)
		funcCode = funcCode.replace(", ",",\r\n\t");
	
	
	if (divElement){
		divCode = document.getElementById("item_"+ currentExampleId).innerHTML;
	} else {
		divCode = document.getElementById("item_default").innerHTML;
	}
	
	i = 1;
	while (divCode.indexOf("name=\"progressbar\"") != -1){
		divCode = divCode.replace("name=\"progressbar\"", "id=\"my_progress_bar_"+ i +"\"");
		i++;
	}
		
	while (divCode.indexOf("\t") != -1)
		divCode = divCode.replace("\t","");
	
	styleCode = styleElement.innerHTML;
	if (styleCode.indexOf(".ex"+ currentExampleId +" ") != -1 || styleCode.indexOf(".ex"+ currentExampleId +"_") != -1){
		var startInx = styleCode.indexOf("ex"+ currentExampleId +" ") - 1;
		var endInx = -1;
		
		if (startInx == -2)
			startInx = styleCode.indexOf("ex"+ currentExampleId +"_");
		
		i = currentExampleId + 1;
		
		var exampleExists = false;
		
		while (true){
			eval("exampleExists = (typeof example_"+ i +" != 'undefined');");
			if (!exampleExists)
				break;

			if (styleCode.indexOf("ex"+ i +" ", startInx+1) != -1 || styleCode.indexOf("ex"+ i +"_", startInx+1) != -1){
				endInx = styleCode.indexOf("ex"+ i +" ", startInx+1);

				if (endInx == -1)
					endInx = styleCode.indexOf("ex"+ i +"_", startInx+1);

				endInx = endInx - 1;

				break;
			}
			
			i++;
		}

		if (endInx != -1){
			styleCode = styleCode.substr(startInx, endInx - startInx);
		} else {
			styleCode = styleCode.substr(startInx);
		}

		while (styleCode.indexOf("ex" + currentExampleId) != -1)
			styleCode = styleCode.replace("ex" + currentExampleId, "my_progress_bar");
		
		while (funcCode.indexOf("ex" + currentExampleId) != -1)
			funcCode = funcCode.replace("ex" + currentExampleId, "my_progress_bar");
		
	} else {
		styleCode = "";
	}
	
	r += '<link rel="stylesheet" type="text/css" href="progressbar.css" />' + "\r\n";
	r += '<script type="text/javascript" src="progressbar.js"></'+'script>' + "\r\n";
	if (styleCode != ""){
		r += '<style type="text/css">' + "\r\n";
		r += styleCode + "\r\n";
		r += '</style>' + "\r\n";
	}
	r += divCode + "\r\n";
	r += "\r\n";
	r += '<script type="text/javascript">' + "\r\n";
	r += "\r\n";
	r += 'var myProgressBar = null' + "\r\n";
	r += 'var timerId = null' + "\r\n";
	r += "\r\n";
	r += funcCode + "\r\n";
	r += "\r\n";
	r += 'loadProgressBar();' + "\r\n";
	r += '</'+'script>' + "\r\n\r\n";
	
	prv.value = r;
	
	con.style.display = 'block';
	//con.style.height = '400px';
}
function hideCode(){
	var con = document.getElementById('preview_code_cont');
	con.style.display = 'none';
	//con.style.height = '0px';
}
function showItem(inx){
	currentExampleId = inx;
	
	var temp = "";
	var i = 0;
	var showDescription = true;
	var showCustom = true;
	
	if ($("item_"+inx)){
		temp = $("item_"+inx).innerHTML;
	} else {
		temp = $("item_default").innerHTML;
	}
	
	while (temp.indexOf("name=\"progressbar\"") != -1){
		i++;
		temp = temp.replace("name=\"progressbar\"", "id=\"progressbar_"+ inx + "_" + i +"\"");
	}
	$("preview_item").innerHTML = temp;
	
	if (myProgressBar && myProgressBar.animation){
		if (myProgressBar.animation.timerId != null)
			clearInterval(myProgressBar.animation.timerId);
		if (myProgressBar.animation.smoothTimerId != null)
			clearInterval(myProgressBar.animation.smoothTimerId); 
	}
	if (timerId != null){
		clearTimeout(timerId);
		clearInterval(timerId);
	}
	myProgressBar = null;
	
	if ($("item_description_"+inx) && $("item_description_"+inx).innerHTML != ""){		
		$("preview_description").innerHTML = $("item_description_"+inx).innerHTML;
		$("preview_description").style.display = "";
		showDescription = true;
	} else {
		$("preview_description").style.display = "none";
		showDescription = false;
	}
	
	var item = itemList[inx];
	
	if (item){
		
		var tempHTML = "";
		
		var tempCustomHeight = 290; 
		var tempCustomHeightDivided = 0;
		
		if (item.showAnimationStyles){
			tempHTML += "Animation style<br/><select id=\"animation_style\" onchange=\"changeAnimationStyle(this);\">";
			for (i in ProgressBar.AnimationStyle)
				tempHTML += "<option value=\""+ ProgressBar.AnimationStyle[i] +"\">"+ i +"</option>";
			tempHTML += "</select>";
			tempCustomHeight -= 33;
		}
		
		if (item.showAnimationSpeed){
			tempHTML += "Animation speed<br/><select id=\"animation_speed\" onchange=\"changeAnimationSpeed(this);\">";
			tempHTML += "<option value=\"0.25\">very slow</option>";
			tempHTML += "<option value=\"0.5\">slow</option>";
			tempHTML += "<option value=\"1\">normal</option>";
			tempHTML += "<option value=\"2\">fast</option>";
			tempHTML += "<option value=\"4\">very fast</option>";
			tempHTML += "</select>";
			tempCustomHeight -= 33;
		}
		
		if (item.showAnimationSmoothness){
			tempHTML += "Animation smoothness<br/><select id=\"animation_smooth\" onchange=\"changeAnimationSmoothness(this);\">";
			for (i in ProgressBar.AnimationSmoothness)
				tempHTML += "<option value=\""+ ProgressBar.AnimationSmoothness[i] +"\">"+ i +"</option>";
			tempHTML += "</select>";
			tempCustomHeight -= 33;
		}
		
		if (item.foregrounds) tempCustomHeightDivided++;
		if (item.backgrounds) tempCustomHeightDivided++;
		if (item.markers) tempCustomHeightDivided++;
		
		if (item.foregrounds){
			tempHTML += "Foreground<br/><div style=\"overflow: auto; height: "+ (Math.round(tempCustomHeight/tempCustomHeightDivided)-15) +"px;\">";
			for (i = 0; i < item.foregrounds.length; i++)
				tempHTML += "<div class=\"custom_item\" style=\"background-image: url('"+ item.foregrounds[i] +"');\" onclick=\"changeForeground(this);\"></div>";
			tempHTML += "</div>";
		}
		
		if (item.backgrounds){
			tempHTML += "Background<br/><div style=\"overflow: auto; height: "+ (Math.round(tempCustomHeight/tempCustomHeightDivided)-15) +"px;\">";
			for (i = 0; i < item.backgrounds.length; i++)
				tempHTML += "<div class=\"custom_item_bg\" style=\"background-image: url('"+ item.backgrounds[i] +"');\" onclick=\"changeBackground(this);\"></div>";
			tempHTML += "</div>";
		}
		
		if (item.markers){
			tempHTML += "Markers<br/><div style=\"overflow: auto; height: "+ (Math.round(tempCustomHeight/tempCustomHeightDivided)-15) +"px;\">";
			for (i = 0; i < item.markers.length; i++)
				tempHTML += "<div class=\"custom_item_marker\" style=\"background-image: url('"+ item.markers[i] +"');\" onclick=\"changeMarker(this);\"></div>";
			tempHTML += "</div>";
		}
		
		if (tempHTML != ""){
			$("preview_custom").innerHTML = tempHTML;
			showCustom = true;
		} else {
			showCustom = false;
		}
	} else {
		showCustom = false;
	}
	
	if (showCustom){
		$("preview_custom").style.display = "";
	} else {
		$("preview_custom").style.display = "none";
	}
	
	if (!item || !item.previewBackground){
		$("preview_container").style.backgroundImage = "url('bg/default.jpg')";
	} else {
		$("preview_container").style.backgroundImage = "url('" + item.previewBackground +"')";
	}
	
	if (!item || !item.layoutIndex || item.layoutIndex == 0){
		$("preview_description").style.height = "";
		
		$("preview_description").style.cssFloat = "left";
		$("preview_description").style.width = (showCustom ? "380px" : "500px");
		
		$("preview_item").style.cssFloat = "left";
		$("preview_item").style.width = (showCustom ? "400px" : "520px");
		$("preview_item").style.height = (showDescription ? ((298 - $("preview_description").clientHeight) + "px") : "298px");
		
		$("preview_custom").style.cssFloat = "right";
		$("preview_custom").style.width = "100px";
		
	} else if (item.layoutIndex == 1){
		
		$("preview_description").style.cssFloat = "right";
		$("preview_description").style.width = "200px";
		$("preview_description").style.height = "290px";
		
		$("preview_item").style.cssFloat = "left";
		$("preview_item").style.width = (showDescription ? (showCustom ? "180px" : "300px") : (showCustom ? "400px" : "520px"))		
		$("preview_item").style.height = "290px";
		
		$("preview_custom").style.cssFloat = "left";
		$("preview_custom").style.width = "100px";
		
	}
	
	eval("example_"+ inx +"()");
	
	if (showCustom){
		if ($("animation_style"))
			$("animation_style").value = myProgressBar.animationStyle;
		if ($("animation_speed"))
			$("animation_speed").value = myProgressBar.animationSpeed;
		if ($("animation_smooth"))
			$("animation_smooth").value = myProgressBar.animationSmoothness;
	}
}


function toggleVisibility(elementId){
	var elem = document.getElementById(elementId);
	var display = ProgressBar._elementCurrentStyle(elem,"display");

	if (display == 'none'){
		elem.style.display = 'table';
	} else {
		elem.style.display = 'none';
	}
}


function getBackgroundImageUrl(elem){
	var temp = elem.style.backgroundImage;
	var i = 0;
	var replaces = ["url(\"","url(",")","\""];
	
	for (i = 0; i < replaces.length; i++)
	while (temp.indexOf(replaces[i]) != -1)
		temp = temp.replace(replaces[i],"");
	
	return temp;
}
function changeForeground(elem){
	if (myProgressBar){
		var i = 0;
		var temp = getBackgroundImageUrl(elem);
		if (myProgressBar[0]){
			for (i = 0; i < myProgressBar.length; i++)
				myProgressBar[i].setForeground(temp);
		} else {
			myProgressBar.setForeground(temp);
		}
	}
}

function changeBackground(elem){
	if (myProgressBar){
		var i = 0;
		var temp = getBackgroundImageUrl(elem);
		if (myProgressBar[0]){
			for (i = 0; i < myProgressBar.length; i++)
				myProgressBar[i].setBackground(temp);
		} else {
			myProgressBar.setBackground(temp);
		}
	}
}

function changeMarker(elem){
	if (myProgressBar){
		var i = 0;
		var temp = getBackgroundImageUrl(elem);
		if (myProgressBar[0]){
			for (i = 0; i < myProgressBar.length; i++)
				myProgressBar[i].setMarkerImage(temp);
		} else {
			myProgressBar.setMarkerImage(temp);
		}
	}
}

function changeAnimationStyle(elem){
	if (myProgressBar){
		if (myProgressBar[0]){
			var i = 0;
			for (i = 0; i < myProgressBar.length; i++)
				myProgressBar[i].setAnimationStyle(parseInt(elem.value));
		} else {
			myProgressBar.setAnimationStyle(parseInt(elem.value));
		}
	}
}

function changeAnimationSpeed(elem){
	if (myProgressBar){
		if (myProgressBar[0]){
			var i = 0;
			for (i = 0; i < myProgressBar.length; i++)
				myProgressBar[i].animationSpeed = parseFloat(elem.value);
		} else {
			myProgressBar.animationSpeed = parseFloat(elem.value);
		}
	}
}

function changeAnimationSmoothness(elem){
	if (myProgressBar){
		if (myProgressBar[0]){
			var i = 0;
			for (i = 0; i < myProgressBar.length; i++)
				myProgressBar[i].animationSmoothness = parseFloat(elem.value);
		} else {
			myProgressBar.animationSmoothness = parseFloat(elem.value);
		}
	}
}


// -----------------------------------------------------------------------------------------------------------

function example_0(){
	myProgressBar = new ProgressBar("progressbar_0_1",{
		borderRadius: 10,
		width: 300,
		height: 20,
		maxValue: 100,
		labelText: "Loaded in {value,0} %",
		orientation: ProgressBar.Orientation.Horizontal,
		direction: ProgressBar.Direction.LeftToRight,
		animationStyle: ProgressBar.AnimationStyle.LeftToRight1,
		animationSpeed: 1.5,
		imageUrl: 'images/v_fg12.png',
		backgroundUrl: 'images/h_bg2.png',
		markerUrl: 'images/marker2.png'
	});
	
	timerId = window.setInterval(function() {
		if (myProgressBar.value >= myProgressBar.maxValue)
			myProgressBar.setValue(0);
		else
			myProgressBar.setValue(myProgressBar.value+1);
		
	}, 100);
}

function example_1(){
	myProgressBar = new ProgressBar("progressbar_1_1",{
		borderRadius: 10,
		height: 200,
		width: 20,
		orientation: ProgressBar.Orientation.Vertical,
		direction: ProgressBar.Direction.BottomToTop,
		imageUrl: 'images/v_fg2.png',
		backgroundUrl: 'images/v_bg2.png'
	});

	timerId = window.setInterval(function() {
		if (myProgressBar.value >= myProgressBar.maxValue)
			myProgressBar.setValue(0);
		else
			myProgressBar.setValue(myProgressBar.value+1);
		
	}, 100);
}

function example_2(){
	myProgressBar = [
		new ProgressBar("progressbar_2_1",{
			borderRadius: 10,
			height: 20,
			width: 300,
			orientation: ProgressBar.Orientation.Horizontal,
			direction: ProgressBar.Direction.RightToLeft,
			imageUrl: 'images/h_fg2.png',
			backgroundUrl: 'images/h_bg2.png'
		}), 
		new ProgressBar("progressbar_2_2",{
			borderRadius: 10,
			height: 20,
			width: 300,
			orientation: ProgressBar.Orientation.Horizontal,
			direction: ProgressBar.Direction.LeftToRight,
			imageUrl: 'images/h_fg2.png',
			backgroundUrl: 'images/h_bg2.png'
		})
	]
	timerId = window.setInterval(function() {
		var i = 0;
		for (i = 0; i < myProgressBar.length; i++){
			if (myProgressBar[i].value >= myProgressBar[i].maxValue)
				myProgressBar[i].setValue(0);
			else
				myProgressBar[i].setValue(myProgressBar[i].value+1);
		}
	}, 100);
}

function example_3(){
	myProgressBar = [
		new ProgressBar("progressbar_3_1",{
			borderRadius: 10,
			height: 200,
			width: 20,
			orientation: ProgressBar.Orientation.Vertical,
			direction: ProgressBar.Direction.RightToLeft,
			imageUrl: 'images/v_fg2.png',
			backgroundUrl: 'images/v_bg2.png'
		}), 
		new ProgressBar("progressbar_3_2",{
			borderRadius: 10,
			height: 200,
			width: 20,
			orientation: ProgressBar.Orientation.Vertical,
			direction: ProgressBar.Direction.LeftToRight,
			imageUrl: 'images/v_fg2.png',
			backgroundUrl: 'images/v_bg2.png'
		})
	]
	timerId = window.setInterval(function() {
		var i = 0;
		for (i = 0; i < myProgressBar.length; i++){
			if (myProgressBar[i].value >= myProgressBar[i].maxValue)
				myProgressBar[i].setValue(0);
			else
				myProgressBar[i].setValue(myProgressBar[i].value+1);
		}
	}, 100);
}

function example_4(){
	myProgressBar = [
		new ProgressBar("progressbar_4_1",{
			value: 40,
			borderRadius: 10,
			height: 12,
			width: 250,
			orientation: ProgressBar.Orientation.Horizontal,
			direction: ProgressBar.Direction.LeftToRight,
			imageUrl: 'images/h_fg2.png',
			backgroundUrl: 'images/h_bg2.png'
		}), 
		new ProgressBar("progressbar_4_2",{
			value: 60,
			borderRadius: 10,
			height: 20,
			width: 300,
			orientation: ProgressBar.Orientation.Horizontal,
			direction: ProgressBar.Direction.LeftToRight,
			imageUrl: 'images/h_fg2.png',
			backgroundUrl: 'images/h_bg2.png'
		}),
		new ProgressBar("progressbar_4_3",{
			value: 80,
			borderRadius: 10,
			height: 30,
			width: 200,
			orientation: ProgressBar.Orientation.Horizontal,
			direction: ProgressBar.Direction.LeftToRight,
			imageUrl: 'images/h_fg8.png',
			backgroundUrl: 'images/h_bg2.png'
		})
	]
}

function example_5(){
	myProgressBar = [
		new ProgressBar("progressbar_5_1",{
			value: 40,
			borderRadius: 1,
			height: 30,
			width: 300,
			orientation: ProgressBar.Orientation.Horizontal,
			direction: ProgressBar.Direction.LeftToRight,
			imageUrl: 'images/h_fg8.png',
			backgroundUrl: 'images/h_bg2.png'
		}), 
		new ProgressBar("progressbar_5_2",{
			value: 60,
			borderRadius: 8,
			height: 30,
			width: 300,
			orientation: ProgressBar.Orientation.Horizontal,
			direction: ProgressBar.Direction.LeftToRight,
			imageUrl: 'images/h_fg8.png',
			backgroundUrl: 'images/h_bg2.png'
		}),
		new ProgressBar("progressbar_5_3",{
			value: 80,
			borderRadius: 20,
			height: 30,
			width: 300,
			orientation: ProgressBar.Orientation.Horizontal,
			direction: ProgressBar.Direction.LeftToRight,
			imageUrl: 'images/h_fg8.png',
			backgroundUrl: 'images/h_bg2.png'
		})
	]
}

function example_6(){
	myProgressBar = new ProgressBar("progressbar_6_1",{
		borderRadius: 5,
		width: 250,
		height: 30,
		value: 90,
		labelText: "Loaded in {progress} %",
		orientation: ProgressBar.Orientation.Horizontal,
		direction: ProgressBar.Direction.LeftToRight,
		animationStyle: ProgressBar.AnimationStyle.LeftToRight2,
		animationSpeed: 0.25,
		imageUrl: 'images/h_fg8.png',
		backgroundUrl: 'images/h_bg2.png'
	});
}

function example_7(){
	myProgressBar = new ProgressBar("progressbar_7_1",{
		borderRadius: 5,
		width: 250,
		height: 20,
		orientation: ProgressBar.Orientation.Horizontal,
		direction: ProgressBar.Direction.LeftToRight,
		animationStyle: ProgressBar.AnimationStyle.LeftToRight2,
		animationSpeed: 0.25,
		imageUrl: 'images/h_fg6.png',
		backgroundUrl: 'images/h_bg2.png'
	});
	
	timerId = window.setInterval(function() {
		if (myProgressBar.isLoaded){
			var newValue = 0;
				
			if (!(myProgressBar.value >= myProgressBar.maxValue))
				newValue = myProgressBar.value + 2;
			
			if (newValue < 25){
				myProgressBar.setForeground('images/h_fg6.png');
			} else if (newValue < 50){
				myProgressBar.setForeground('images/h_fg9.png');
			} else if (newValue < 75){
				myProgressBar.setForeground('images/h_fg7.png');
			} else {
				myProgressBar.setForeground('images/h_fg4.png');
			}
			
			myProgressBar.setValue(newValue);
		}
		
	}, 100);
}

function example_8(){
	myProgressBar = new ProgressBar("progressbar_8_1",{
		borderRadius: 20,
		width: 400,
		height: 30,
		maxValue: 100,
		showLabel: false,
		orientation: ProgressBar.Orientation.Horizontal,
		direction: ProgressBar.Direction.LeftToRight,
		imageUrl: 'images/h_fg8.png',
		backgroundUrl: 'images/h_bg2.png',
		onValueChanged: function(){
			if (myProgressBar && myProgressBar.captionElement){
				myProgressBar.captionElement.innerHTML = 'Loading ' + Math.round(myProgressBar.progress*100) + "%";
				
				var newLeft = myProgressBar.progressPosition + 10;
				var lim = 400 - myProgressBar.captionElement.offsetWidth;
				if (newLeft > lim)
					newLeft = lim;
	
				myProgressBar.captionElement.style.left = (newLeft) + "px";
			}
		}
	});
	
	myProgressBar.captionElement = myProgressBar.parentElement.previousSibling;
	myProgressBar.setValue(0);
	
	timerId = window.setInterval(function() {
		if (myProgressBar.value >= myProgressBar.maxValue)
			myProgressBar.setValue(0);
		else
			myProgressBar.setValue(myProgressBar.value+1);
	}, 100);
}

function example_9(){
	myProgressBar = new ProgressBar("progressbar_9_1",{
		borderRadius: 5,
		width: 400,
		height: 10,
		maxValue: 100,
		showLabel: false,
		orientation: ProgressBar.Orientation.Horizontal,
		direction: ProgressBar.Direction.LeftToRight,
		animationStyle: ProgressBar.AnimationStyle.LeftToRight1,
		animationSpeed: 0.4,
		imageUrl: 'images/h_fg5.png',
		backgroundUrl: 'images/h_bg1.png',
		onValueChanged: function(){
			if (myProgressBar && myProgressBar.captionElement)
				myProgressBar.captionElement.innerHTML = 'Loaded in ' + Math.round(myProgressBar.progress*100) + " %";
		}
	});
	
	myProgressBar.captionElement = myProgressBar.parentElement.nextSibling;
	myProgressBar.setValue(0);
	
	timerId = window.setInterval(function() {
		if (myProgressBar.value >= myProgressBar.maxValue)
			myProgressBar.setValue(0);
		else
			myProgressBar.setValue(myProgressBar.value+1);
	}, 100);
}

function example_10(){
	var data = [44,73,5,42,10,26,54,29,38,5,64,53,23,51,40];
	var i = 0;
	myProgressBar = [];
	for (i = 0; i < data.length; i++)
		myProgressBar.push(
			new ProgressBar("progressbar_10_1",{
				borderRadius: 0,
				value: data[i],
				width: 20,
				height: 200,
				maxValue: 100,
				labelText: "{value,0}",
				extraClassName: {
					parent: "ex10_wrapper", 
					left: "ex10", 
					right: "ex10", 
					middle: "ex10",
					background: "ex10_background",
					verticalText: "ex10_vertical_text"
				},
				creationType: ProgressBar.CreationType.AppendChild,
				orientation: ProgressBar.Orientation.Vertical,
				direction: ProgressBar.Direction.BottomToTop,
				animationStyle: ProgressBar.AnimationStyle.StaticFull,
				animationSmoothness: ProgressBar.AnimationSmoothness.Smooth1,
				imageUrl: 'images/v_fg11.png',
				markerUrl: 'images/marker6.png'
			})	
		);
}

function example_11(){
	var i = 0;
	myProgressBar = [];
	for (i = 0; i < 10; i++)
		myProgressBar.push(
			new ProgressBar("progressbar_11_1",{
				width: 20,
				height: 100,
				minValue: 1,
				maxValue: 10,
				showLabel: false,
				extraClassName: {
					parent: "ex11_wrapper", 
					wrapper: "ex11", 
					background: "ex11_background"
				},
				creationType: ProgressBar.CreationType.AppendChild,
				orientation: ProgressBar.Orientation.Vertical,
				direction: ProgressBar.Direction.BottomToTop,
				animationStyle: ProgressBar.AnimationStyle.StaticFull,
				imageUrl: 'images/v_fg12.png',
				markerUrl: 'images/marker7.png'
			})	
		);
	
	timerId = window.setInterval(function() {
		var i = 0;
		for (i = 0; i < myProgressBar.length; i++){
			if (i == 0){
				myProgressBar[i].setValue(myProgressBar[i].value + Math.round(Math.random()*(myProgressBar[i].maxValue/1.6)-((myProgressBar[i].maxValue/1.6)/2)));
			} else {
				myProgressBar[i].setValue(myProgressBar[i-1].value + Math.round(Math.random()*(myProgressBar[i].maxValue/1.6)-((myProgressBar[i].maxValue/1.6)/2)));
			}
		}
	}, 150);
}

function example_12(){
	var data = [26,34,19,14,5,2];
	var labels = ['Yogi Bear','Fred Flinston','Goofy','Scooby Doo','Johnny B.','I.M. Weasel'];
	
	var i = 0;
	myProgressBar = [];
	for (i = 0; i < data.length; i++){
		myProgressBar.push(
			new ProgressBar("progressbar_12_1",{
				borderRadius: 0,
				value: data[i],
				width: 200,
				height: 20,
				maxValue: 50,
				labelText: data[i] + " %",
				extraClassName: {
					parent: "ex12_wrapper", 
					left: "ex12", 
					right: "ex12", 
					middle: "ex12",
					background: "ex12_background",
					horizontalText: "ex12_horizontal_text"
				},
				creationType: ProgressBar.CreationType.AppendChild,
				orientation: ProgressBar.Orientation.Horizontal,
				direction: ProgressBar.Direction.LeftToRight,
				animationStyle: ProgressBar.AnimationStyle.None,
				animationSmoothness: ProgressBar.AnimationSmoothness.Smooth1,
				imageUrl: 'images/h_fg11.png'
			})	
		);
		
		var labelElement = document.createElement("DIV");
		labelElement.innerHTML = labels[i];
		labelElement.style.width = "100px";
		labelElement.style.height = "20px";
		labelElement.style.lineHeight = "20px";
		labelElement.style.marginLeft = "10px";
		labelElement.style.cssFloat = "left";
		labelElement.style.display = "inline-block";
		document.getElementById("progressbar_12_1").appendChild(labelElement);
			
	}
}

function example_13(){
	myProgressBar = new ProgressBar("progressbar_13_1",{
		borderRadius: 15,
		width: 250,
		height: 30,
		value: 25,
		maxValue: 100,
		labelText: "Loaded in {progress} %",
		orientation: ProgressBar.Orientation.Horizontal,
		direction: ProgressBar.Direction.LeftToRight,
		animationStyle: ProgressBar.AnimationStyle.LeftToRight1,
		animationSmoothness: ProgressBar.AnimationSmoothness.Smooth1,
		animationSpeed: 1.5,
		imageUrl: 'images/h_fg8.png',
		backgroundUrl: 'images/h_bg2.png'
	});
	
	timerId = window.setInterval(function() {

		if (myProgressBar.value >= myProgressBar.maxValue){
			myProgressBar.setValue(0);
		} else {
			myProgressBar.setValue(myProgressBar.value + 25);
		}
					
	}, 2500);
}

function example_14(){
	myProgressBar = new ProgressBar("progressbar_14_1",{
		borderRadius: 15,
		width: 300,
		height: 30,
		value: 25,
		maxValue: 100,
		extraClassName: {
			wrapper: 'ex14',
			horizontalText: 'ex14_text_horizontal'
		},
		orientation: ProgressBar.Orientation.Horizontal,
		direction: ProgressBar.Direction.LeftToRight,
		animationStyle: ProgressBar.AnimationStyle.Flickering1,
		animationSmoothness: ProgressBar.AnimationSmoothness.Smooth1,
		animationSpeed: 0.5,
		imageUrl: 'images/h_fg201.png',
		markerUrl: 'images/marker.png',
		backgroundUrl: 'images/marker8.png'
	});
	
	timerId = window.setInterval(function() {

		if (myProgressBar.value >= myProgressBar.maxValue){
			myProgressBar.setValue(0);
		} else {
			myProgressBar.setValue(myProgressBar.value + 25);
		}
					
	}, 2500);
}

function example_15(){
	myProgressBar = new ProgressBar("progressbar_15_1",{
		borderRadius: 10,
		width: 400,
		height: 20,
		value: 0,
		maxValue: 400,
		showLabel: false,
		extraClassName: {
			wrapper: 'ex15_wrapper'
		},
		orientation: ProgressBar.Orientation.Horizontal,
		direction: ProgressBar.Direction.LeftToRight,
		animationInterval: 50,
		imageUrl: 'images/h_fg202.png',
		backgroundUrl: 'images/h_bg3.png'
	});
	
	timerId = window.setInterval(function() {
		//myProgressBar.animationSmoothness = ProgressBar.AnimationSmoothness.Smooth1;
		
		if (myProgressBar.value >= myProgressBar.maxValue){
			myProgressBar.setValue(0);
		} else {
			myProgressBar.setValue(myProgressBar.value + 20);
		}
					
	}, 100);
}

function example_16(){
	myProgressBar = new ProgressBar("progressbar_16_1",{
		borderRadius: 5,
		width: 320,
		height: 22,
		value: 25,
		maxValue: 100,
		orientation: ProgressBar.Orientation.Horizontal,
		direction: ProgressBar.Direction.LeftToRight,
		animationStyle: ProgressBar.AnimationStyle.Static,
		animationSmoothness: ProgressBar.AnimationSmoothness.Smooth1,
		animationSpeed: 0.5,
		imageUrl: 'images/h_fg5.png',
		markerUrl: 'images/marker9.png',
		backgroundUrl: 'images/h_bg3.png'
	});
	
	timerId = window.setInterval(function() {

		if (myProgressBar.value >= myProgressBar.maxValue){
			myProgressBar.setValue(0);
		} else {
			myProgressBar.setValue(myProgressBar.value + 25);
		}
					
	}, 2500);
}

function example_17(){
	myProgressBar = new ProgressBar("progressbar_17_1",{
		borderRadius: 5,
		width: 180,
		height: 22,
		value: 25,
		maxValue: 100,
		extraClassName: {
			horizontalText: 'ex17_text_horizontal'
		},
		orientation: ProgressBar.Orientation.Horizontal,
		direction: ProgressBar.Direction.LeftToRight,
		animationStyle: ProgressBar.AnimationStyle.StaticFull,
		animationSmoothness: ProgressBar.AnimationSmoothness.Smooth1,
		animationSpeed: 0.5,
		imageUrl: 'images/ajax-loader.gif',
		markerUrl: 'images/marker8.png',
		backgroundUrl: 'images/marker8.png'
	});
	
	timerId = window.setInterval(function() {

		if (myProgressBar.value >= myProgressBar.maxValue){
			myProgressBar.setValue(0);
		} else {
			myProgressBar.setValue(myProgressBar.value + 25);
		}
					
	}, 2500);
}

function example_18(){
	myProgressBar = new ProgressBar("progressbar_18_1",{
		borderRadius: 20,
		width: 400,
		height: 40,
		value: 25,
		maxValue: 100,
		extraClassName: {
			wrapper: 'ex18_wrapper',
			horizontalText: 'ex18_text_horizontal'
		},
		orientation: ProgressBar.Orientation.Horizontal,
		direction: ProgressBar.Direction.LeftToRight,
		animationStyle: ProgressBar.AnimationStyle.None,
		animationSmoothness: ProgressBar.AnimationSmoothness.Smooth1,
		animationSpeed: 0.5,
		imageUrl: 'images/h_fg203.png',
		backgroundUrl: 'images/marker10.png'
	});
	
	timerId = window.setInterval(function() {

		if (myProgressBar.value >= myProgressBar.maxValue){
			myProgressBar.setValue(0);
		} else {
			myProgressBar.setValue(myProgressBar.value + 25);
		}
					
	}, 2500);
}

function example_19(){
	myProgressBar = new ProgressBar("progressbar_19_1",{
		borderRadius: 10,
		width: 300,
		height: 20,
		value: 25,
		maxValue: 100,

		orientation: ProgressBar.Orientation.Horizontal,
		direction: ProgressBar.Direction.LeftToRight,
		animationStyle: ProgressBar.AnimationStyle.LeftToRight1,
		animationSmoothness: ProgressBar.AnimationSmoothness.Smooth1,
		animationSpeed: 1.5,
		imageUrl: 'images/h_fg2.png',
		markerUrl: 'images/marker11.png',
		backgroundUrl: 'images/marker10.png'
	});
	
	timerId = window.setInterval(function() {

		if (myProgressBar.value >= myProgressBar.maxValue){
			myProgressBar.setValue(0);
		} else {
			myProgressBar.setValue(myProgressBar.value + 25);
		}
					
	}, 2500);
}
