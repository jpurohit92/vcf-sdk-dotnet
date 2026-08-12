# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementLifecycleContentLibrariesSummary
The Vcenter.NamespaceManagement.Lifecycle.Content.Libraries.Summary schema provides basic information about the Content Library configured with vSphere Namespaces.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Library** | [**VcenterNamespaceManagementLifecycleContentLibrariesContentLibrarySpec**](VcenterNamespaceManagementLifecycleContentLibrariesContentLibrarySpec.md) | Details of the Content Library.  This property was added in __vSphere API 9.0.0.0__. | 
**Status** | **string** | Indicates the configuration status of vSphere Namespaces with this Content Library.  Possible values:   - &#x60;CONFIGURING&#x60;: Indicates vSphere Namespaces is being configured with Content Library.   - &#x60;READY&#x60;: Indicates vSphere Namespaces is ready to consume the Content Library. Expected status transition: 1. CONFIGURING - -&gt; READY   - &#x60;REMOVING&#x60;: Indicates the Content Library is being removed and vSphere Namespaces is de-configured with Content Library. Expected status transition: 2. CONFIGURING - -&gt; REMOVING 3. READY - -&gt; REMOVING   - &#x60;ERROR&#x60;: Indicates configuring the vSphere Namespaces with Content Library has an error or Content Library is not available anymore. The expected transitions: 1. CONFIGURING - -&gt; ERROR 2. CONFIGURING - -&gt; READY - -&gt; CONFIGURING - -&gt; ERROR 2. CONFIGURING - -&gt; READY - -&gt; ERROR 3. CONFIGURING - -&gt; READY - -&gt; REMOVING - -&gt; ERROR 4. CONFIGURING - -&gt; REMOVING - -&gt; ERROR   For more information see: *Vcenter.NamespaceManagement.Lifecycle.Content.Libraries.Status*.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

