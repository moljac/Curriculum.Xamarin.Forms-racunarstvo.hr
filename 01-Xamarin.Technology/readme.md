# Xamarin.Technology

*	Xamarin.Technology Features
	*	Cross-Platform
		*	**NOT** hybrid (hybrid is possible)
	*	utilizes .net/mono technology
		* 	mono - open source .net implementation for non Windows platforms
		*	programming languages
			*	c#
			*	f#
	*	Native
		*	definition:
			*	vendor chosen development ecosystem/environment
				*	Android: Linux + java
				*	iOS: MachOS/Darwin (unixoid) + objective-c/swift
		*	100% (1:1) API coverage (Android and iOS)
		*	native performance
			*	time complexity 
				+/- 1-3% compared to "native"
			*	space complexity
				*	storeage (disk): 3-5Mb bigger
				*	RAM - about the same
	
*	Xamarin 2 approaches
	*	[Xamarin.]Standard		
		programming in c# instead of java
	*	[Xamarin.]Forms
		*	normalized (common) abstraction layer over 3+ platforms
		*	LCD - least common denominator
			*	bottom up
			*	start small
		*	shared code
			*	binary level		
				Portable Class Libraries PCL
			*	source code level	
				Shared Asset Project (SAP)		
*	cross platform development
	*	pros
		*	cost saving (effort)
			*	development/implementation: 
				*	sharing code
					*	binary level
					*	source code level
			*	testing
				*	testing does not have to be done on all platforms
	*	cons
		*	complexity
			*	technology/tools
			*	knowledge
			*	experience
		*	discipline (Rules-n-Recommendations - styleguides)
		*	cost
					
## Xplat - Cross Platform


## Features

### Native

###	Performance



## Demo Technology Approaches

###	Xamarin.Standard/Xamarin.Traditional

1.	Create Android App
2.	Start App in Emulator
3.	Demo: Xamarin is native		
	1.	Android UI defined in xml (axml)		
		Resources/layout/Main.axml		
		add more controld/widgets		
	2.	Architecture/Structure
		$TARGET=Debug|Release		
		obj/$TARGET/android/AndroidManifes.xml		
		obj/$TARGET/android/src/**/*.java		
		obj/$TARGET/android/projectname/**/*.java		
4.	Show click Event
5.	Working with AndroidManifest.xml		
	[TODO]
6.	Java vs. c# idioms 		
	MainActivity.CSharp.Event.cs
	MainActivity.Java.Listener.cs
7.	Activity + Intents - navigation

###	Xamarin.Forms

1.	Create Android App
2.	Start emulator
3.	Show click Event


