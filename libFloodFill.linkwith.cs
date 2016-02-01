using ObjCRuntime;

[assembly: LinkWith ("libFloodFill.a",LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Simulator64,
	Frameworks = "Foundation UIKit CoreGraphics QuartzCore",LinkerFlags = "-ObjC",
	SmartLink = true, ForceLoad = true)]
