# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationPrivilegeChecksListResult
The Vcenter.Authorization.PrivilegeChecks.ListResult schema contains information about the performed privilege checks, if there are any further privilege checks available for reading, and if there are privilege checks potentially missing.  This schema was added in __vSphere API 8.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**List&lt;VcenterAuthorizationPrivilegeChecksInfo&gt;**](VcenterAuthorizationPrivilegeChecksInfo.md) | Privilege checks that match the specified*Vcenter.Authorization.PrivilegeChecks.FilterSpec* and *Vcenter.Authorization.PrivilegeChecks.IterationSpec* in chronological order as they were performed. Each check is recorded only the first time it is made. If more than one privilege check matches a given *Vcenter.Authorization.PrivilegeChecks.FilterSpec* (for example, two different opIDs checked System.Read for the same object and the same principal, a FilterSpec which specifies only the principal will only contain the first check).  This property was added in __vSphere API 8.0.0.0__. | 
**Marker** | **string** | An opaque marker indicating the last returned privilege check. If there are more privilege checks collected than were returned, the next ones can be retrieved directly by passing this value to another call to com.vmware.vcenter.authorization.PrivilegeChecks.list.     This property was added in __vSphere API 8.0.0.0__. | 
**Truncated** | **bool** | In case *Vcenter.Authorization.PrivilegeChecks.IterationSpec.marker* was specified and valid, but the privilege check indicated by it is no longer stored, ListResult.truncated is set to True to indicate that some privilege checks are potentially missing.    The number of privilege checks stored is determined by the value of config.vpxd.privilegeChecks.bufferSize advanced option.  This property was added in __vSphere API 8.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

