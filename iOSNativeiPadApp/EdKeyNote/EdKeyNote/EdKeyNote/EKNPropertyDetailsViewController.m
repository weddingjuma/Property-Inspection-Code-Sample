//
//  EKNPropertyDetailsViewController.m
//  EdKeyNote
//
//  Created by canviz on 9/22/14.
//  Copyright (c) 2014 canviz. All rights reserved.
//

#import "EKNPropertyDetailsViewController.h"

@interface EKNPropertyDetailsViewController ()

@end

@implementation EKNPropertyDetailsViewController

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];
    if (self) {
        // Custom initialization
    }
    return self;
}

- (void)viewDidLoad
{
    [super viewDidLoad];
    self.navigationController.navigationBar.hidden = YES;
    self.view.backgroundColor = [UIColor colorWithRed:239.00f/255.00f green:239.00f/255.00f blue:244.00f/255.00f alpha:1];    
    
    UIFont *boldfont = [UIFont fontWithName:@"Helvetica-Bold" size:18];
    NSString *lbl1str = @"PROPERTY DETAILS";
    NSDictionary *attributes = @{NSFontAttributeName:boldfont};
    CGSize lbsize = [lbl1str sizeWithAttributes:attributes];
    UILabel *lbl1 = [[UILabel alloc] initWithFrame:CGRectMake(160/2, 320/2, lbsize.width, lbsize.height)];
    //lbl1.backgroundColor = [UIColor clearColor];
    lbl1.text = lbl1str;
    lbl1.textAlignment = NSTextAlignmentLeft;
    lbl1.font = boldfont;
    lbl1.textColor = [UIColor colorWithRed:132.00f/255.00f green:132.00f/255.00f blue:137.00f/255.00f alpha:1];
    [self.view addSubview:lbl1];
    
    self.propertyDetailsTableView = [[UITableView alloc] initWithFrame:CGRectMake(160/2, 380/2, 610/2, 360/2) style:UITableViewStylePlain];
    self.propertyDetailsTableView.delegate = self;
    self.propertyDetailsTableView.dataSource = self;
    [self.view addSubview:self.propertyDetailsTableView];
    
    [self loadData];
    
    // Do any additional setup after loading the view.
}

-(void)loadData{
    
    //Turn on Spinner
    UIActivityIndicatorView* spinner = [[UIActivityIndicatorView alloc]initWithFrame:CGRectMake(135,140,50,50)];
    spinner.activityIndicatorViewStyle = UIActivityIndicatorViewStyleGray;
    [self.view addSubview:spinner];
    spinner.hidesWhenStopped = YES;
    [spinner startAnimating];
    
    //Replace this URL with SP REST API URL
    NSString *requestUrl = @"http://api.openweathermap.org/data/2.5/weather?q=london,uk";
    
    //Add the access token to the Authorization header
    NSString *authorizationHeaderValue = [NSString stringWithFormat:@"Bearer %@", self.token];
    
    NSMutableURLRequest *request = [NSMutableURLRequest requestWithURL:[NSURL URLWithString:requestUrl]];
    [request setValue:authorizationHeaderValue forHTTPHeaderField:@"Authorization"];
    
    //Create NSURLSession
    NSURLSession *session = [NSURLSession sharedSession];
    
    //Turn on network indicator
    [[UIApplication sharedApplication] setNetworkActivityIndicatorVisible:YES];
    
    //Create NSURLSessionDataTask and call REST API
    NSURLSessionDataTask *task = [session dataTaskWithRequest:request completionHandler:^(NSData *data,
                                                                                      NSURLResponse *response,
                                                                                      NSError *error) {
     
        //Turn off network indicator
        [[UIApplication sharedApplication] setNetworkActivityIndicatorVisible:YES];
        
        //Turn off spinner
        dispatch_async(dispatch_get_main_queue(), ^{
            [spinner stopAnimating];
        });

        //Handle error
        if (error != nil) {
            NSString *errorMessage = [@"Error accessing O365 SharePoint REST APIs. Reason: " stringByAppendingString: error.description];
            UIAlertView *alert = [[UIAlertView alloc] initWithTitle:@"Error" message:errorMessage delegate:self cancelButtonTitle:@"Retry" otherButtonTitles:@"Cancel", nil];
            [alert show];
        }
                
        //Process the data and bind to the user interface
        NSLog(@"%@", data);
        //self.SharepointList  = lists;
    }];
    
    [task resume];
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender
{
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

-(void)initParameter:(NSMutableArray *)historyarray
{
    self.inspectionHistory = historyarray;
}

- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView {
    return 1;
        
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section {
   if(tableView == self.propertyDetailsTableView)
   {
       return 3;
       //return [self.SharepointList count];
   }
    return 0;
}

- (CGFloat)tableView:(UITableView *)tableView heightForRowAtIndexPath:(NSIndexPath *)indexPath {
    if(tableView == self.propertyDetailsTableView)
    {
        if(indexPath.row == 3)
        {
            return 70;
        }
        else
        {
            return 40;
        }

    }
    return 40;
}

- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath {
    if(tableView == self.propertyDetailsTableView)
    {
        UITableViewCell *cell = nil;
        NSString *identifier = @"PropertyCellID";
        cell = [tableView dequeueReusableCellWithIdentifier:identifier];
        if (cell == nil) {
            cell = [[UITableViewCell alloc] initWithStyle:UITableViewCellStyleSubtitle reuseIdentifier:identifier];
            cell.textLabel.opaque = NO;
            cell.textLabel.textColor = [UIColor blackColor];
            
            if(indexPath.row == 1)
            {
                
            }
            cell.textLabel.text = ((EKNInspectionData *)self.inspectionHistory[self.currentSelectIndex]).inspectionProperty.propertyTitle;
            
            cell.textLabel.numberOfLines = 1;
            cell.textLabel.font = [UIFont systemFontOfSize:15];
            [cell.textLabel setNumberOfLines:5];
            
            [cell setSelectionStyle:UITableViewCellSelectionStyleBlue];
            cell.accessoryType = UITableViewCellAccessoryDisclosureIndicator;
        }
        return cell;
    }
    else
    {
        return nil;
    }
    
}

@end