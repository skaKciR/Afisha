/*
	Telephasic by HTML5 UP
	html5up.net | @ajlkn
	Free for personal and commercial use under the CCA 3.0 license (html5up.net/license)
*/

(function($) {

	var	$window = $(window),
		$body = $('body');

	// Breakpoints.
		breakpoints({
			normal:    [ '1081px',  '1280px'  ],
			narrow:    [ '821px',   '1080px'  ],
			narrower:  [ '737px',   '820px'   ],
			mobile:    [ '481px',   '736px'   ],
			mobilep:   [ null,      '480px'   ]
		});

	// Play initial animations on page load.
		$window.on('load', function() {
			window.setTimeout(function() {
				$body.removeClass('is-preload');
			}, 100);
		});

	// Dropdowns.
		$('#nav > ul').dropotron({
			mode: 'fade',
			speed: 300,
			alignment: 'center',
			noOpenerFade: true
		});

	// Nav.

		// Button.
			$(
				'<div id="navButton">' +
					'<a href="#navPanel" class="toggle"></a>' +
				'</div>'
			)
				.appendTo($body);

		// Panel.
			$(
				'<div id="navPanel">' +
					'<nav>' +
						'<a href="index.html" class="link depth-0">Home</a>' +
						$('#nav').navList() +
					'</nav>' +
				'</div>'
			)
				.appendTo($body)
				.panel({
					delay: 500,
					hideOnClick: true,
					resetScroll: true,
					resetForms: true,
					side: 'top',
					target: $body,
					visibleClass: 'navPanel-visible'
				});


	// Slider
	$.global = new Object();

	$.global.item = 1;
	$.global.total = 0;

	$(document).ready(function () {

		var WindowWidth = $(window).width();
		var SlideCount = $('#slides li').length;
		var SlidesWidth = SlideCount * WindowWidth;

		$.global.item = 0;
		$.global.total = SlideCount;

		$('.slide').css('width', WindowWidth + 'px');
		$('#slides').css('width', SlidesWidth + 'px');

		$("#slides li:nth-child(1)").addClass('alive');

		$('#left').click(function () { Slide('back'); });
		$('#right').click(function () { Slide('forward'); });

	});

	function Slide(direction) {

		if (direction == 'back') { var $target = $.global.item - 1; }
		if (direction == 'forward') { var $target = $.global.item + 1; }

		if ($target == -1) { DoIt($.global.total - 1); }
		else if ($target == $.global.total) { DoIt(0); }
		else { DoIt($target); }


	}

	function DoIt(target) {

		var $windowwidth = $(window).width();
		var $margin = $windowwidth * target;
		var $actualtarget = target + 1;

		$("#slides li:nth-child(" + $actualtarget + ")").addClass('alive');

		$('#slides').css('transform', 'translate3d(-' + $margin + 'px,0px,0px)');

		$.global.item = target;

		$('#count').html($.global.item + 1);

	}

})(jQuery);