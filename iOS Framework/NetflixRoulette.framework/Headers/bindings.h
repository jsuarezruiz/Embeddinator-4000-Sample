#include "embeddinator.h"
#import <Foundation/Foundation.h>


#if !__has_feature(objc_arc)
#error Embeddinator code must be built with ARC.
#endif

// forward declarations
@class NetflixRoulette_NetflixRouletteFetcher;
@class NetflixRoulette_NetflixRouletteResult;


NS_ASSUME_NONNULL_BEGIN


/** Class NetflixRoulette_NetflixRouletteFetcher
 *  Corresponding .NET Qualified Name: `NetflixRoulette.NetflixRouletteFetcher, NetflixRoulette, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`
 */
@interface NetflixRoulette_NetflixRouletteFetcher : NSObject {
	// This field is not meant to be accessed from user code
	@public MonoEmbedObject* _object;
}

- (nullable instancetype)initWithMovie:(NSString *)movie;

/** This type is not meant to be created using only default values
 *  Both the `-init` and `+new` selectors cannot be used to create instances of this type.
 */
- (nullable instancetype)init NS_UNAVAILABLE;
+ (nullable instancetype)new NS_UNAVAILABLE;


@property (nonatomic, readonly) NSString *name;

- (NetflixRoulette_NetflixRouletteResult*)getMovie;
/** This selector is not meant to be called from user code
 *  It exists solely to allow the correct subclassing of managed (.net) types
 */
- (nullable instancetype)initForSuper;

@end


/** Class NetflixRoulette_NetflixRouletteResult
 *  Corresponding .NET Qualified Name: `NetflixRoulette.NetflixRouletteResult, NetflixRoulette, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`
 */
@interface NetflixRoulette_NetflixRouletteResult : NSObject {
	// This field is not meant to be accessed from user code
	@public MonoEmbedObject* _object;
}

- (nullable instancetype)init;


@property (nonatomic) NSString *category;
@property (nonatomic) NSString *director;
@property (nonatomic) int mediaType;
@property (nonatomic) NSString *poster;
@property (nonatomic) NSString *rating;
@property (nonatomic) NSString *releaseYear;
@property (nonatomic) NSString *showCast;
@property (nonatomic) int showId;
@property (nonatomic) NSString *showTitle;
@property (nonatomic) NSString *summary;
@property (nonatomic) int unit;
/** This selector is not meant to be called from user code
 *  It exists solely to allow the correct subclassing of managed (.net) types
 */
- (nullable instancetype)initForSuper;

@end

NS_ASSUME_NONNULL_END

