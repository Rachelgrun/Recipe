--AS Amazing work! 100% Please see one comment, no need to resubmit.
--use RecipeDB
go 

drop table if exists RecipeCookBook
drop table if exists CookBook
drop table if exists RecipeMealCourse
drop table if exists MealCourse
drop table if exists Meal
drop table if exists Course
drop table if exists Step
drop table if exists RecipeIngredient
drop table if exists Recipe
drop table if exists CuisineType
drop table if exists Users 
drop table if exists MeasurementType
drop table if exists Ingredient


go 
Create Table dbo.Ingredient(
    IngredientID int not null identity primary key,
    IngredientName Varchar(50) not null Constraint ck_IngredientName_cannot_be_blank check (IngredientName<> '')
    Constraint u_Ingredient_IngredientName Unique
)
go 

Create Table dbo.MeasurementType(
    MeasurementTypeId int not null identity primary key,
    MeasurementTypeName Varchar(15) not null Constraint MeasurementType_cannot_be_blank check (MeasurementTypeName <>'')
    Constraint u_MeasurementType_MeasurementTypeName unique   
)
go 


Create Table dbo.Users(
    UserId int not null identity primary key ,
    UserFirstName varchar(20) not null Constraint ck_UserFirstName_cannot_be_blank check (UserFirstName <>''),
    UserLastName Varchar(30) not null Constraint ck_UserLastName_cannot_be_blank check (UserLastName <>''),
    UserPassword varchar(15) not null  Constraint ck_UserPassword_cannot_be_blank check (UserPassword <>''),
    Constraint u_Users_FirstName_LastName_UserPasswoard Unique (UserFirstName,UserLastName,UserPassword)
)

go 

Create Table dbo.CuisineType(
    CuisineTypeId int not null identity primary key, 
    CuisineTypeName varchar(15) not null Constraint ck_CuisineTypeName_cannot_be_blank check (CuisineTypeName <>'') 
    Constraint u_CuisineType_CuisineTypeName Unique

)

go 
Create Table dbo.Recipe(
    RecipeId int not null identity primary key, 
    CreatedByUserId int not null constraint f_Recipe_CreatedByUserId foreign key references Users(UserId),
    CuisineTypeId int not null constraint f_Recipe_CuisineType foreign key references CuisineType(CuisineTypeId),
    RecipeName Varchar (100) not null constraint ck_RecipeName_cannot_be_blank check (RecipeName <>'')
    Constraint u_Recipe_RecipeName unique,
    Calories int not null constraint ck_Calories_must_be_greater_than_zero check (Calories >=0),
    DateDrafted date not null default getdate()
    Constraint ck_DateDrafted_must_be_after_the_website_created_but_less_than_the_future check(DateDrafted between '2019-02-08'and getdate()),
    DatePublished date null Constraint ck_DatePublished_cannot_be_in_the_future check(DatePublished <= getdate()),
    DateArchived date null Constraint ck_DateArchived_cannot_be_in_the_future check(DateArchived <= getdate()),
    RecipeStatus as case 
                when DatePublished is null and DateArchived is null then 'Drafted'
                when DatePublished is not null and datearchived is null then 'Published'
                when dateArchived is not null then 'archived' 
                end,
    constraint ck_DateArchived_Must_be_after_DateDrafted check (DateArchived >= DateDrafted),
    constraint ck_DateArchived_Must_be_after_DatePublished check (DateArchived>=DatePublished),
--AS Take out the extra comma
    Constraint ck_DatePublished_must_be_after_DateDrafted check (DatePublished>= DateDrafted)
)

alter table Recipe drop column if exists Code
go
alter table Recipe add Code as replace(concat(RecipeName,'-',Calories,'-','Calories'),' ','-') persisted
go
go 
Create Table dbo.RecipeIngredient(
   RecipeIngredientId int not null identity primary key,  
    RecipeId int not null constraint f_RecipeIngredient_Recipe foreign key references Recipe(RecipeId),
    IngredientID int not null constraint f_RecipeIngredient_Ingredient foreign key references Ingredient(IngredientID),
    MeasurementTypeId int not null constraint f_RecipeIngredient_MeasurementType foreign key references MeasurementType(MeasurementTypeId),
    MeasurementQuantity Decimal (5,2) not null constraint ck_Quantity_must_be_greater_than_zero check (MeasurementQuantity >0),
    IngredientSequence int not null constraint ck_IngredientSequence_must_be_greater_than_zero check (IngredientSequence >0),
   constraint u_RecipeId_IngredientID unique (RecipeId,IngredientId) 

)

go 
Create Table dbo.Step(
    StepId int not null identity primary key, 
    RecipeID int not null constraint f_Step_Recipe foreign key references  Recipe(RecipeId),
    StepDesc Varchar(300) not null constraint ck_StepDesc_cannot_be_blank check (StepDesc<>''),
    StepSequence int not null constraint ck_StepSequence_must_be_greater_than_zero check (StepSequence >0),
    Constraint u_StepSequence_RecipeId unique (StepSequence,RecipeId)
)

go 

Create Table dbo.Course(
    CourseId int not null identity primary key, 
    CourseName Varchar(20) not null Constraint ck_CourseName_cannot_be_blank check(CourseName <>'')
     constraint u_Course_CourseName unique, 
    CourseSequence int not null constraint ck_CourseSequence_must_be_greater_than_zero check  (CourseSequence >0)
)

go 


Create Table dbo.Meal(
    MealId int not null identity primary key, 
    UserId int not null constraint  f_Meal_User foreign key references Users(UserId),
    MealTitle varchar (100) not null constraint ck_MealTitle_cannot_be_blank check (MealTitle <>''),
    DateMealCreated date not null default getdate()
    constraint ck_DateMealCreated_must_be_after_the_Website_was_created_but_not_in_future check (DateMealCreated between '2019-02-08' and getdate()),
    MealActive bit not null default 1 ,
    constraint u_UserId_MealTitle  unique (UserId,MealTitle)
) 

go 
Create Table dbo.MealCourse(
    MealCourseId int not null identity primary key, 
    CourseId int not null constraint f_MealCourse_Course foreign key references Course(CourseId),
    MealId int  not null constraint f_MealCourse_Meal foreign key references Meal(MealId),
    constraint u_CourseId_MealId unique (CourseId,MealId)
)

go 
Create Table dbo.RecipeMealCourse(
   RecipeMealCourseId int not null identity primary key, 
    RecipeId int not null constraint f_RecipeMealCourse_Recipe foreign key references  Recipe(RecipeId),
    MealCourseId int not null constraint f_RecipeMealCourse_MealCourse foreign key references MealCourse(MealCourseId),
    DishTypeMain bit not null default 1,
    constraint u_RecipeId_MealCourseId unique (RecipeId,MealCourseId)
    
)

go 
Create Table dbo.Cookbook(
    CookbookId int not null identity primary key, 
    UserId int not null constraint f_Cookbook_UserId foreign key references Users(UserId),
    CookbookTitle varchar (30) not null constraint ck_CookbookTitle_cannot_be_blank check (CookbookTitle <>'')
    Constraint u_Cookbook_CookbookTitle unique,
    Price decimal(5,2) not null constraint ck_Price_must_be_greater_than_zero check (Price >0),
    DateCookbookCreated date not null default getdate()
    Constraint ck_DateCookbookCreated_must_be_after_the_website_and_cannot_be_in_the_future check (DateCookbookCreated between '2019-02-08' and getdate()),
    CookbookActive bit not null default 1 ,
   constraint u_CookbookTitle_UserId unique (CookbookTitle,UserId)
)

go 

Create Table dbo.RecipeCookbook(
    RecipeCookbookId int not null identity primary key, 
    RecipeId int not null constraint f_RecipeCookbook_Recipe foreign key references Recipe(RecipeId),
    CookbookId int not null constraint f_RecipeCookbook_Cookbook foreign key references Cookbook(CookbookId),
    RecipeSequence int not null constraint ck_RecipeSequence_must_be_greater_than_zero check (RecipeSequence >0),
    constraint u_CookbookId_RecipeId unique (CookbookId,RecipeId)
)


go 