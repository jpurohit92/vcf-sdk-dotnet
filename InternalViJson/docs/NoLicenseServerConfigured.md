# Vcenter.ViJson.OpenApi.Model.NoLicenseServerConfigured
The NoLicenseServerConfigured fault is thrown when there is no valid license server configured for the system and the system is not in evaluation mode.  Any operation occurs that requires evaluation license or a valid license will throw the NoLicenseServerConfigured. This can happen with the new licensing scheme that is a hybrid of flex-based licensing and serial number based licensing. There can be cases where VirtualCenter is licensed by a serial number and there is no need for a flex license server. These cases are valid as long as no operation that requires flex- based license server is invoked, for example, adding a pre-4.0 host that requires flex licenses. If however, such an operation is invoked, the NoLicenseServerConfigured fault is thrown. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

