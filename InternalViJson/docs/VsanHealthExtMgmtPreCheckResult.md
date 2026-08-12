# Vcenter.ViJson.OpenApi.Model.VsanHealthExtMgmtPreCheckResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OverallResult** | **bool** | Indicates if all the pre-checks are passed  | 
**EsxVersionCheckPassed** | **bool** | Indicates if the ESX version check is passed or not.  The required ESX version must be higher than 6.0.0  | [optional] 
**DrsCheckPassed** | **bool** | Indicates if the DRS fully automated check is passed or not.  DRS must be enabled for installing health service extension  | [optional] 
**EamConnectionCheckPassed** | **bool** | Indicates if the EAM connectivity check is passed or not The EAM must be connected for installing health service extension  | [optional] 
**InstallStateCheckPassed** | **bool** | Indicates if the vSAN health extension is ready for uninstallation.  The health extension can be uninstalled if the installation is completed  | [optional] 
**Results** | [**List&lt;VsanClusterHealthTest&gt;**](VsanClusterHealthTest.md) | Pre-checks test results for install/uninstall vSAN health service Detail results are combined in tables for client to retrieve  | 
**VumRegistered** | **bool** | Indicates whether VUM has registered to current vCenter.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

