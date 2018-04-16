#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

extern "C"
{
    void DebugUnityLog(const char* pLog)
    {
        NSString* tLog = [NSString stringWithUTF8String:pLog];
        NSLog( @"%@", tLog );
    }
}
