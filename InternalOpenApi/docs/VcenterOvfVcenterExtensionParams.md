# Vcenter.Automation.OpenApi.Model.VcenterOvfVcenterExtensionParams
The Vcenter.Ovf.VcenterExtensionParams schema specifies that the OVF package should be registered as a vCenter extension. The virtual machine or virtual appliance will gain unrestricted access to the vCenter Server APIs. It must be connected to a network with connectivity to the vCenter server.    See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy* and *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=filter*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Required** | **bool** | Whether registration as a vCenter extension is required.  This property is not used in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**RegistrationAccepted** | **bool** | Whether registration as a vCenter extension is accepted.    If registration as a vCenter extension is required (see *Vcenter.Ovf.VcenterExtensionParams.required*), this must be set to true during deployment. Defaults to false when returned from server.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 
**Type** | **string** | Unique identifier describing the type of the OVF parameters. The value is the name of the OVF parameters schema.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

