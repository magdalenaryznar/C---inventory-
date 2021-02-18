<a name='assembly'></a>
# Inventory.WPF

## Contents

- [App](#T-WpfInventory-App 'WpfInventory.App')
  - [InitializeComponent()](#M-WpfInventory-App-InitializeComponent 'WpfInventory.App.InitializeComponent')
  - [Main()](#M-WpfInventory-App-Main 'WpfInventory.App.Main')
- [CsvFile](#T-WpfInventory-Model-CsvFile 'WpfInventory.Model.CsvFile')
- [DataGridView](#T-WpfInventory-DataGridView 'WpfInventory.DataGridView')
  - [InitializeComponent()](#M-WpfInventory-DataGridView-InitializeComponent 'WpfInventory.DataGridView.InitializeComponent')
- [DataGridViewModel](#T-WpfInventory-DataGridViewModel 'WpfInventory.DataGridViewModel')
  - [#ctor()](#M-WpfInventory-DataGridViewModel-#ctor 'WpfInventory.DataGridViewModel.#ctor')
  - [Products](#P-WpfInventory-DataGridViewModel-Products 'WpfInventory.DataGridViewModel.Products')
  - [RemoveCommand](#P-WpfInventory-DataGridViewModel-RemoveCommand 'WpfInventory.DataGridViewModel.RemoveCommand')
  - [GetStoredProducts()](#M-WpfInventory-DataGridViewModel-GetStoredProducts 'WpfInventory.DataGridViewModel.GetStoredProducts')
- [DataRepository](#T-Inventory-WPF-Services-DataRepository 'Inventory.WPF.Services.DataRepository')
  - [#ctor()](#M-Inventory-WPF-Services-DataRepository-#ctor 'Inventory.WPF.Services.DataRepository.#ctor')
  - [GetAllProduts()](#M-Inventory-WPF-Services-DataRepository-GetAllProduts 'Inventory.WPF.Services.DataRepository.GetAllProduts')
  - [GetProductName(name)](#M-Inventory-WPF-Services-DataRepository-GetProductName-System-String- 'Inventory.WPF.Services.DataRepository.GetProductName(System.String)')
  - [GetTax(taxAmount)](#M-Inventory-WPF-Services-DataRepository-GetTax-System-Decimal- 'Inventory.WPF.Services.DataRepository.GetTax(System.Decimal)')
  - [GetUnitByName(name)](#M-Inventory-WPF-Services-DataRepository-GetUnitByName-System-String- 'Inventory.WPF.Services.DataRepository.GetUnitByName(System.String)')
  - [UpdateProducts(updatedProducts)](#M-Inventory-WPF-Services-DataRepository-UpdateProducts-System-Collections-Generic-List{Inventory-WPF-DbModels-Product}- 'Inventory.WPF.Services.DataRepository.UpdateProducts(System.Collections.Generic.List{Inventory.WPF.DbModels.Product})')
- [FileFactory](#T-WpfInventory-Factories-FileFactory 'WpfInventory.Factories.FileFactory')
  - [CreateCsv(products)](#M-WpfInventory-Factories-FileFactory-CreateCsv-System-Collections-Generic-List{WpfInventory-Product}- 'WpfInventory.Factories.FileFactory.CreateCsv(System.Collections.Generic.List{WpfInventory.Product})')
- [IFile](#T-WpfInventory-Model-IFile 'WpfInventory.Model.IFile')
- [MainViewModel](#T-WpfInventory-ViewModel-MainViewModel 'WpfInventory.ViewModel.MainViewModel')
  - [#ctor()](#M-WpfInventory-ViewModel-MainViewModel-#ctor 'WpfInventory.ViewModel.MainViewModel.#ctor')
  - [AddCommand](#P-WpfInventory-ViewModel-MainViewModel-AddCommand 'WpfInventory.ViewModel.MainViewModel.AddCommand')
  - [UpdateDbCommand](#P-WpfInventory-ViewModel-MainViewModel-UpdateDbCommand 'WpfInventory.ViewModel.MainViewModel.UpdateDbCommand')
  - [ExecuteAddProduct(parameter)](#M-WpfInventory-ViewModel-MainViewModel-ExecuteAddProduct-System-Object- 'WpfInventory.ViewModel.MainViewModel.ExecuteAddProduct(System.Object)')
  - [ExecuteUpdateDatabase(obj)](#M-WpfInventory-ViewModel-MainViewModel-ExecuteUpdateDatabase-System-Object- 'WpfInventory.ViewModel.MainViewModel.ExecuteUpdateDatabase(System.Object)')
  - [Print(datagrid)](#M-WpfInventory-ViewModel-MainViewModel-Print-System-Windows-Controls-DataGrid- 'WpfInventory.ViewModel.MainViewModel.Print(System.Windows.Controls.DataGrid)')
  - [SaveFile(fileName)](#M-WpfInventory-ViewModel-MainViewModel-SaveFile-System-String- 'WpfInventory.ViewModel.MainViewModel.SaveFile(System.String)')
- [MainWindow](#T-WpfInventory-MainWindow 'WpfInventory.MainWindow')
  - [InitializeComponent()](#M-WpfInventory-MainWindow-InitializeComponent 'WpfInventory.MainWindow.InitializeComponent')
- [PrintCommand](#T-Inventory-WPF-Commands-PrintCommand 'Inventory.WPF.Commands.PrintCommand')
  - [#ctor(dataGrid,title)](#M-Inventory-WPF-Commands-PrintCommand-#ctor-System-Windows-Controls-DataGrid,System-String- 'Inventory.WPF.Commands.PrintCommand.#ctor(System.Windows.Controls.DataGrid,System.String)')
  - [Print(dataGrid,title)](#M-Inventory-WPF-Commands-PrintCommand-Print-System-Windows-Controls-DataGrid,System-String- 'Inventory.WPF.Commands.PrintCommand.Print(System.Windows.Controls.DataGrid,System.String)')
  - [Run()](#M-Inventory-WPF-Commands-PrintCommand-Run 'Inventory.WPF.Commands.PrintCommand.Run')
- [Product](#T-Inventory-WPF-DbModels-Product 'Inventory.WPF.DbModels.Product')
- [Product](#T-WpfInventory-Product 'WpfInventory.Product')
- [ProductName](#T-Inventory-WPF-DbModels-ProductName 'Inventory.WPF.DbModels.ProductName')
- [ProductTax](#T-Inventory-WPF-DbModels-ProductTax 'Inventory.WPF.DbModels.ProductTax')
- [SaveCommand](#T-WpfInventory-Commands-SaveCommand 'WpfInventory.Commands.SaveCommand')
  - [#ctor(path)](#M-WpfInventory-Commands-SaveCommand-#ctor-System-String- 'WpfInventory.Commands.SaveCommand.#ctor(System.String)')
  - [CanExecute(parameter)](#M-WpfInventory-Commands-SaveCommand-CanExecute-System-Object- 'WpfInventory.Commands.SaveCommand.CanExecute(System.Object)')
  - [Execute(parameter)](#M-WpfInventory-Commands-SaveCommand-Execute-System-Object- 'WpfInventory.Commands.SaveCommand.Execute(System.Object)')
- [Unit](#T-Inventory-WPF-DbModels-Unit 'Inventory.WPF.DbModels.Unit')
- [UpdateDatabaseCommand](#T-Inventory-WPF-Commands-UpdateDatabaseCommand 'Inventory.WPF.Commands.UpdateDatabaseCommand')
  - [#ctor(products)](#M-Inventory-WPF-Commands-UpdateDatabaseCommand-#ctor-System-Collections-Generic-List{WpfInventory-Product}- 'Inventory.WPF.Commands.UpdateDatabaseCommand.#ctor(System.Collections.Generic.List{WpfInventory.Product})')
  - [GetProductsModel(productsToSave)](#M-Inventory-WPF-Commands-UpdateDatabaseCommand-GetProductsModel-System-Collections-Generic-List{WpfInventory-Product}- 'Inventory.WPF.Commands.UpdateDatabaseCommand.GetProductsModel(System.Collections.Generic.List{WpfInventory.Product})')
  - [Run()](#M-Inventory-WPF-Commands-UpdateDatabaseCommand-Run 'Inventory.WPF.Commands.UpdateDatabaseCommand.Run')
- [ViewModelBase](#T-WpfInventory-ViewModelBase 'WpfInventory.ViewModelBase')
  - [OnPropertyChanged(name)](#M-WpfInventory-ViewModelBase-OnPropertyChanged-System-String- 'WpfInventory.ViewModelBase.OnPropertyChanged(System.String)')
- [WpfInventoryContext](#T-Inventory-WPF-Database-WpfInventoryContext 'Inventory.WPF.Database.WpfInventoryContext')
  - [#ctor()](#M-Inventory-WPF-Database-WpfInventoryContext-#ctor 'Inventory.WPF.Database.WpfInventoryContext.#ctor')
  - [ProductNames](#P-Inventory-WPF-Database-WpfInventoryContext-ProductNames 'Inventory.WPF.Database.WpfInventoryContext.ProductNames')
  - [ProductTaxes](#P-Inventory-WPF-Database-WpfInventoryContext-ProductTaxes 'Inventory.WPF.Database.WpfInventoryContext.ProductTaxes')
  - [Products](#P-Inventory-WPF-Database-WpfInventoryContext-Products 'Inventory.WPF.Database.WpfInventoryContext.Products')
  - [Units](#P-Inventory-WPF-Database-WpfInventoryContext-Units 'Inventory.WPF.Database.WpfInventoryContext.Units')

<a name='T-WpfInventory-App'></a>
## App `type`

##### Namespace

WpfInventory

##### Summary

Interaction logic for App.xaml

<a name='M-WpfInventory-App-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-WpfInventory-App-Main'></a>
### Main() `method`

##### Summary

Application Entry Point.

##### Parameters

This method has no parameters.

<a name='T-WpfInventory-Model-CsvFile'></a>
## CsvFile `type`

##### Namespace

WpfInventory.Model

##### Summary

CSV file model

<a name='T-WpfInventory-DataGridView'></a>
## DataGridView `type`

##### Namespace

WpfInventory

##### Summary

Interaction logic for DataGridView.xaml

<a name='M-WpfInventory-DataGridView-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-WpfInventory-DataGridViewModel'></a>
## DataGridViewModel `type`

##### Namespace

WpfInventory

##### Summary

DataGrid view model

<a name='M-WpfInventory-DataGridViewModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates DataGridViewModel

##### Parameters

This constructor has no parameters.

<a name='P-WpfInventory-DataGridViewModel-Products'></a>
### Products `property`

##### Summary

Visible products

<a name='P-WpfInventory-DataGridViewModel-RemoveCommand'></a>
### RemoveCommand `property`

##### Summary

Remove product command

<a name='M-WpfInventory-DataGridViewModel-GetStoredProducts'></a>
### GetStoredProducts() `method`

##### Summary

Retrieves stored products from database

##### Parameters

This method has no parameters.

<a name='T-Inventory-WPF-Services-DataRepository'></a>
## DataRepository `type`

##### Namespace

Inventory.WPF.Services

##### Summary

Repository for stored data

<a name='M-Inventory-WPF-Services-DataRepository-#ctor'></a>
### #ctor() `constructor`

##### Summary

Create repository

##### Parameters

This constructor has no parameters.

<a name='M-Inventory-WPF-Services-DataRepository-GetAllProduts'></a>
### GetAllProduts() `method`

##### Summary

Retrieves all products from database

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Inventory-WPF-Services-DataRepository-GetProductName-System-String-'></a>
### GetProductName(name) `method`

##### Summary

Get product name by ist name

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Inventory-WPF-Services-DataRepository-GetTax-System-Decimal-'></a>
### GetTax(taxAmount) `method`

##### Summary

Get tax by amount

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| taxAmount | [System.Decimal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Decimal 'System.Decimal') |  |

<a name='M-Inventory-WPF-Services-DataRepository-GetUnitByName-System-String-'></a>
### GetUnitByName(name) `method`

##### Summary

Get unit by name

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Inventory-WPF-Services-DataRepository-UpdateProducts-System-Collections-Generic-List{Inventory-WPF-DbModels-Product}-'></a>
### UpdateProducts(updatedProducts) `method`

##### Summary

Update all products in database.
Warning! Deletes all previous one!

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| updatedProducts | [System.Collections.Generic.List{Inventory.WPF.DbModels.Product}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Inventory.WPF.DbModels.Product}') |  |

<a name='T-WpfInventory-Factories-FileFactory'></a>
## FileFactory `type`

##### Namespace

WpfInventory.Factories

##### Summary

FIle factory

<a name='M-WpfInventory-Factories-FileFactory-CreateCsv-System-Collections-Generic-List{WpfInventory-Product}-'></a>
### CreateCsv(products) `method`

##### Summary

Creates CSV file

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| products | [System.Collections.Generic.List{WpfInventory.Product}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{WpfInventory.Product}') |  |

<a name='T-WpfInventory-Model-IFile'></a>
## IFile `type`

##### Namespace

WpfInventory.Model

##### Summary

File interface

<a name='T-WpfInventory-ViewModel-MainViewModel'></a>
## MainViewModel `type`

##### Namespace

WpfInventory.ViewModel

##### Summary

MainView model

<a name='M-WpfInventory-ViewModel-MainViewModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates view model

##### Parameters

This constructor has no parameters.

<a name='P-WpfInventory-ViewModel-MainViewModel-AddCommand'></a>
### AddCommand `property`

##### Summary

Add command

<a name='P-WpfInventory-ViewModel-MainViewModel-UpdateDbCommand'></a>
### UpdateDbCommand `property`

##### Summary

Update db command

<a name='M-WpfInventory-ViewModel-MainViewModel-ExecuteAddProduct-System-Object-'></a>
### ExecuteAddProduct(parameter) `method`

##### Summary

Adds new product to grid

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='M-WpfInventory-ViewModel-MainViewModel-ExecuteUpdateDatabase-System-Object-'></a>
### ExecuteUpdateDatabase(obj) `method`

##### Summary

Updates database

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='M-WpfInventory-ViewModel-MainViewModel-Print-System-Windows-Controls-DataGrid-'></a>
### Print(datagrid) `method`

##### Summary

Prints all visible products in table

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| datagrid | [System.Windows.Controls.DataGrid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.DataGrid 'System.Windows.Controls.DataGrid') |  |

<a name='M-WpfInventory-ViewModel-MainViewModel-SaveFile-System-String-'></a>
### SaveFile(fileName) `method`

##### Summary

Saves file as CSV

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-WpfInventory-MainWindow'></a>
## MainWindow `type`

##### Namespace

WpfInventory

##### Summary

Interaction logic for MainWindow.xaml

<a name='M-WpfInventory-MainWindow-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-Inventory-WPF-Commands-PrintCommand'></a>
## PrintCommand `type`

##### Namespace

Inventory.WPF.Commands

##### Summary

Command for printig

<a name='M-Inventory-WPF-Commands-PrintCommand-#ctor-System-Windows-Controls-DataGrid,System-String-'></a>
### #ctor(dataGrid,title) `constructor`

##### Summary

Command constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataGrid | [System.Windows.Controls.DataGrid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.DataGrid 'System.Windows.Controls.DataGrid') |  |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Inventory-WPF-Commands-PrintCommand-Print-System-Windows-Controls-DataGrid,System-String-'></a>
### Print(dataGrid,title) `method`

##### Summary

Prepare print dialog and execeutes it
Works using DataGrid visual elements

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataGrid | [System.Windows.Controls.DataGrid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.DataGrid 'System.Windows.Controls.DataGrid') |  |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Inventory-WPF-Commands-PrintCommand-Run'></a>
### Run() `method`

##### Summary

Runs command

##### Parameters

This method has no parameters.

<a name='T-Inventory-WPF-DbModels-Product'></a>
## Product `type`

##### Namespace

Inventory.WPF.DbModels

##### Summary

Product entity

<a name='T-WpfInventory-Product'></a>
## Product `type`

##### Namespace

WpfInventory

##### Summary

Product view model

<a name='T-Inventory-WPF-DbModels-ProductName'></a>
## ProductName `type`

##### Namespace

Inventory.WPF.DbModels

##### Summary

Product name entity

<a name='T-Inventory-WPF-DbModels-ProductTax'></a>
## ProductTax `type`

##### Namespace

Inventory.WPF.DbModels

##### Summary

Product tax entity

<a name='T-WpfInventory-Commands-SaveCommand'></a>
## SaveCommand `type`

##### Namespace

WpfInventory.Commands

##### Summary

Command for saving as file

<a name='M-WpfInventory-Commands-SaveCommand-#ctor-System-String-'></a>
### #ctor(path) `constructor`

##### Summary

Creates command using end file path

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-WpfInventory-Commands-SaveCommand-CanExecute-System-Object-'></a>
### CanExecute(parameter) `method`

##### Summary

Checks if can execute command

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='M-WpfInventory-Commands-SaveCommand-Execute-System-Object-'></a>
### Execute(parameter) `method`

##### Summary

Execute command and stores file in correct location

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='T-Inventory-WPF-DbModels-Unit'></a>
## Unit `type`

##### Namespace

Inventory.WPF.DbModels

##### Summary

Product unit entity

<a name='T-Inventory-WPF-Commands-UpdateDatabaseCommand'></a>
## UpdateDatabaseCommand `type`

##### Namespace

Inventory.WPF.Commands

##### Summary

Command for updating products in database

<a name='M-Inventory-WPF-Commands-UpdateDatabaseCommand-#ctor-System-Collections-Generic-List{WpfInventory-Product}-'></a>
### #ctor(products) `constructor`

##### Summary

Creates command

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| products | [System.Collections.Generic.List{WpfInventory.Product}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{WpfInventory.Product}') |  |

<a name='M-Inventory-WPF-Commands-UpdateDatabaseCommand-GetProductsModel-System-Collections-Generic-List{WpfInventory-Product}-'></a>
### GetProductsModel(productsToSave) `method`

##### Summary

Generates product model for database to store

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| productsToSave | [System.Collections.Generic.List{WpfInventory.Product}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{WpfInventory.Product}') |  |

<a name='M-Inventory-WPF-Commands-UpdateDatabaseCommand-Run'></a>
### Run() `method`

##### Summary

Runs all internal methods and execute command.
Saving all new data in database.

##### Parameters

This method has no parameters.

<a name='T-WpfInventory-ViewModelBase'></a>
## ViewModelBase `type`

##### Namespace

WpfInventory

##### Summary

Base class for MVVM pattern

<a name='M-WpfInventory-ViewModelBase-OnPropertyChanged-System-String-'></a>
### OnPropertyChanged(name) `method`

##### Summary

Execute when property changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Inventory-WPF-Database-WpfInventoryContext'></a>
## WpfInventoryContext `type`

##### Namespace

Inventory.WPF.Database

##### Summary

DbContext

<a name='M-Inventory-WPF-Database-WpfInventoryContext-#ctor'></a>
### #ctor() `constructor`

##### Summary

Create dbContext

##### Parameters

This constructor has no parameters.

<a name='P-Inventory-WPF-Database-WpfInventoryContext-ProductNames'></a>
### ProductNames `property`

##### Summary

Store all product names

<a name='P-Inventory-WPF-Database-WpfInventoryContext-ProductTaxes'></a>
### ProductTaxes `property`

##### Summary

Store all taxes

<a name='P-Inventory-WPF-Database-WpfInventoryContext-Products'></a>
### Products `property`

##### Summary

Stores all products

<a name='P-Inventory-WPF-Database-WpfInventoryContext-Units'></a>
### Units `property`

##### Summary

Store all product units
