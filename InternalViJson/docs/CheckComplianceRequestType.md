# Vcenter.ViJson.OpenApi.Model.CheckComplianceRequestType
The parameters of *ProfileComplianceManager.CheckCompliance_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | If specified, check compliance against the specified profiles. If not specified, use the profiles associated with the entities. If both Profiles and Entities are specified, Check the compliance of each Entity against each of the profile specified.    For more information, look at the KMap below.    P represents if Profile is specified.    E represents if Entity is specified.                  P                        ^P       - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --       | Check compliance      |  Profiles associated    |      E|  of each entity       |   with the specified    |       |  against each of the  |   entity will be used   |       |  profiles specified.  |   for checking          |       |                       |   compliance.           |       |                       |                         |       |                       |                         |       - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --       | All entities          |   InvalidArgument       |       |  associated with the  |   Exception is thrown.  |       |  profile are checked. |                         |     ^E|                       |                         |       |                       |                         |       |                       |                         |       |                       |                         |       - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --  Refers instances of *Profile*.  | [optional] 
**Entity** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | If specified, the compliance check is done against this entity.  Refers instances of *ManagedEntity*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

