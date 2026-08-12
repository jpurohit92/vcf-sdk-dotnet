# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementLifecycleContentLibrariesStatus
The Vcenter.NamespaceManagement.Lifecycle.Content.Libraries.Status schema describes the configuration status of the vSphere Namespaces with a Content Library.  Possible values:   - `CONFIGURING`: Indicates vSphere Namespaces is being configured with Content Library.   - `READY`: Indicates vSphere Namespaces is ready to consume the Content Library. Expected status transition: 1. CONFIGURING - -> READY   - `REMOVING`: Indicates the Content Library is being removed and vSphere Namespaces is de-configured with Content Library. Expected status transition: 2. CONFIGURING - -> REMOVING 3. READY - -> REMOVING   - `ERROR`: Indicates configuring the vSphere Namespaces with Content Library has an error or Content Library is not available anymore. The expected transitions: 1. CONFIGURING - -> ERROR 2. CONFIGURING - -> READY - -> CONFIGURING - -> ERROR 2. CONFIGURING - -> READY - -> ERROR 3. CONFIGURING - -> READY - -> REMOVING - -> ERROR 4. CONFIGURING - -> REMOVING - -> ERROR   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

