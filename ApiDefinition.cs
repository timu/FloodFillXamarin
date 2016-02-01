using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace FloodFill
{
	// @interface LinkedListStack : NSObject
	[BaseType (typeof(NSObject))]
	interface LinkedListStack
	{
		// -(id)initWithCapacity:(int)capacity incrementSize:(int)increment andMultiplier:(int)mul;
		[Export ("initWithCapacity:incrementSize:andMultiplier:")]
		IntPtr Constructor (nint capacity, nint increment, nint mul);

		// -(id)initWithCapacity:(int)capacity;
		[Export ("initWithCapacity:")]
		IntPtr Constructor (nint capacity);

		// -(void)pushFrontX:(int)x andY:(int)y;
		[Export ("pushFrontX:andY:")]
		void PushFrontX (nint x, nint y);

		// -(int)popFront:(int *)x andY:(int *)y;
		[Export ("popFront:andY:")]
		unsafe int PopFront (nint x, nint y);
	}

	// @interface FloodFill (UIImage)
	[Category]
	[BaseType (typeof(UIImage))]
	interface UIImage_FloodFill
	{
		// -(UIImage *)floodFillFromPoint:(CGPoint)startPoint withColor:(UIColor *)newColor andTolerance:(int)tolerance;
		[Export ("floodFillFromPoint:withColor:andTolerance:")]
		UIImage FloodFillFromPoint (CGPoint startPoint, UIColor newColor, nint tolerance);

		// -(UIImage *)floodFillFromPoint:(CGPoint)startPoint withColor:(UIColor *)newColor andTolerance:(int)tolerance useAntiAlias:(BOOL)antiAlias;
		[Export ("floodFillFromPoint:withColor:andTolerance:useAntiAlias:")]
		UIImage FloodFillFromPoint (CGPoint startPoint, UIColor newColor, nint tolerance, bool antiAlias);
	}
}

