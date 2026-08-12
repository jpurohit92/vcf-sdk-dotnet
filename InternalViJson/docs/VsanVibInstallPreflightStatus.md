# Vcenter.ViJson.OpenApi.Model.VsanVibInstallPreflightStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ManualVmotionRequired** | **bool** | True if DRS is not configured/enabled in a way that would automatically move VMs when performing EnterMaintenanceMode\\_Task().  In such cases vSAN will issue the EnterMaintenanceMode\\_Task() call, but users need to assist in vMotion of any VMs on that host, either by using DRS manual recommendation application, or by fully manual vMotion.  | 
**RollingRequired** | **bool** | True if there are powered on VMs on the cluster which prevent a all-at-once install of VIBs across the cluster.  Only relevant when the VIBs that need to installed require maintenance mode.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

