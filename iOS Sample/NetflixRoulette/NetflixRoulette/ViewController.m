//
//  ViewController.m
//  NetflixRoulette
//
//  Created by javiersuarezruiz on 30/7/17.
//  Copyright © 2017 javiersuarezruiz. All rights reserved.
//

#import "ViewController.h"
#include "NetflixRoulette/NetflixRoulette.h"

@interface ViewController ()

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
}


- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}
- (IBAction)findMovie:(id)sender {
    NetflixRoulette_NetflixRouletteFetcher * fetcher = [[NetflixRoulette_NetflixRouletteFetcher alloc] initWithMovie: _movieTxtField.text];
    
    NetflixRoulette_NetflixRouletteResult * result = [fetcher getMovie];
    
    if (result) {
        _titleLabel.text = [result showTitle];
        _yearLabel.text = [result releaseYear];
        _ratingLabel.text = [result rating];
        _descLabel.text = [result summary];
    }
}


@end
