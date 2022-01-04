newoption 
{
   trigger = "opengl43",
   description = "use OpenGL 4.3"
}

workspace "StarshipSimEngine"
	configurations { "Debug","Debug.DLL", "Release", "Release.DLL" }
	platforms { "x64", "x86"}

	filter "configurations:Debug"
		defines { "DEBUG" }
		symbols "On"
		
	filter "configurations:Debug.DLL"
		defines { "DEBUG" }
		symbols "On"

	filter "configurations:Release"
		defines { "NDEBUG" }
		optimize "On"	
		
	filter "configurations:Release.DLL"
		defines { "NDEBUG" }
		optimize "On"	
		
	filter { "platforms:x64" }
		architecture "x86_64"
		
	targetdir "bin/%{cfg.buildcfg}/"

project "data"
    kind "StaticLib"
    location "build"
    language "C"
    targetdir "bin/%{cfg.buildcfg}"
	includedirs { "data/include"}
    files {"data/**.h", "data/**.cpp"}

group "Modules"
project "sim_controller"
    kind "StaticLib"
    location "build"
    language "C"
    targetdir "bin/%{cfg.buildcfg}"
    includedirs { "data/include", "modules/communications/include", "modules/engineering/include", "modules/helm/include", "modules/medical/include", "modules/navigation/include", "modules/sciences/include", "modules/sim_controller/include"}

    files {"modules/sim_controller/**.h", "modules/sim_controller/**.cpp"}
    
project "sciences"
    kind "StaticLib"
    location "build"
    language "C"
    targetdir "bin/%{cfg.buildcfg}"
	includedirs { "data/include", "modules/communications/include", "modules/engineering/include", "modules/helm/include", "modules/medical/include", "modules/navigation/include", "modules/sciences/include", "modules/sim_controller/include"}
    files {"modules/sciences/**.h", "modules/sciences/**.cpp"}
    
project "navigation"
    kind "StaticLib"
    location "build"
    language "C"
    targetdir "bin/%{cfg.buildcfg}"
	includedirs { "data/include", "modules/communications/include", "modules/engineering/include", "modules/helm/include", "modules/medical/include", "modules/navigation/include", "modules/sciences/include", "modules/sim_controller/include"}
    files {"modules/navigation/**.h", "modules/navigation/**.cpp"}
    
project "medical"
    kind "StaticLib"
    location "build"
    language "C"
    targetdir "bin/%{cfg.buildcfg}"
	includedirs { "data/include", "modules/communications/include", "modules/engineering/include", "modules/helm/include", "modules/medical/include", "modules/navigation/include", "modules/sciences/include", "modules/sim_controller/include"}
    files {"modules/medical/**.h", "modules/medical/**.cpp"}

project "helm"
    kind "StaticLib"
    location "build"
    language "C"
    targetdir "bin/%{cfg.buildcfg}"
    includedirs { "data/include", "modules/communications/include", "modules/engineering/include", "modules/helm/include", "modules/medical/include", "modules/navigation/include", "modules/sciences/include", "modules/sim_controller/include"}
    files {"modules/helm/**.h", "modules/helm/**.cpp"}

project "engineering"
    kind "StaticLib"
    location "build"
    language "C"
    targetdir "bin/%{cfg.buildcfg}"
    includedirs { "data/include", "modules/communications/include", "modules/engineering/include", "modules/helm/include", "modules/medical/include", "modules/navigation/include", "modules/sciences/include", "modules/sim_controller/include"}
    files {"modules/engineering/**.h", "modules/engineering/**.cpp"}
    
project "communications"
    kind "StaticLib"
    location "build"
    language "C"
    targetdir "bin/%{cfg.buildcfg}"
	includedirs { "data/include", "modules/communications/include", "modules/engineering/include", "modules/helm/include", "modules/medical/include", "modules/navigation/include", "modules/sciences/include", "modules/sim_controller/include"}
    files {"modules/communications/**.h", "modules/communications/**.cpp"}
    
group ""
project "test_app"
	kind "ConsoleApp"
	location "test_app"
	language "C++"
	targetdir "bin/%{cfg.buildcfg}"
	cppdialect "C++17"
	
	vpaths 
	{
		["Header Files"] = { "**.h"},
		["Source Files"] = {"**.c", "**.cpp"},
	}
	files {"test_app/**.c", "test_app/**.cpp", "test_app/**.h"}

	links {"data","communications","engineering","helm","navigation","sciences","sim_controller"}
	
	includedirs { "test_app", "data/include", "modules/communications/include", "modules/engineering/include", "modules/helm/include", "modules/medical/include", "modules/navigation/include", "modules/sciences/include", "modules/sim_controller/include"}

	filter "action:vs*"
		defines{"_WINSOCK_DEPRECATED_NO_WARNINGS", "_CRT_SECURE_NO_WARNINGS", "_WIN32"}
        characterset ("MBCS")
		
	filter "system:windows"
		defines{"_WIN32"}
		links {"winmm", "kernel32", "opengl32", "kernel32", "gdi32"}
		libdirs {"bin/%{cfg.buildcfg}"}
		
	filter "system:linux"
		links {"pthread", "GL", "m", "dl", "rt", "X11"}