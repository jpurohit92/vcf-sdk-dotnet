# Vcenter.ViJson.OpenApi.Model.LicenseEvent
This is a base licensing event to group all license events. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | The event ID.  | 
**ChainId** | **int** | The parent or group ID.  | 
**CreatedTime** | **DateTime** | The time the event was created.  | 
**UserName** | **string** | The user who caused the event.  | 
**Datacenter** | [**DatacenterEventArgument**](DatacenterEventArgument.md) | The Datacenter object of the event.  | [optional] 
**ComputeResource** | [**ComputeResourceEventArgument**](ComputeResourceEventArgument.md) | The ComputeResource object of the event.  | [optional] 
**Host** | [**HostEventArgument**](HostEventArgument.md) | The Host object of the event.  | [optional] 
**Vm** | [**VmEventArgument**](VmEventArgument.md) | The VirtualMachine object of the event.  | [optional] 
**Ds** | [**DatastoreEventArgument**](DatastoreEventArgument.md) | The Datastore object of the event.  | [optional] 
**Net** | [**NetworkEventArgument**](NetworkEventArgument.md) | The Network object of the event.  | [optional] 
**Dvs** | [**DvsEventArgument**](DvsEventArgument.md) | The DistributedVirtualSwitch object of the event.  | [optional] 
**Tgw** | [**TgwEventArgument**](TgwEventArgument.md) | The TransitGateway object of the event.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**FullFormattedMessage** | **string** | A formatted text message describing the event.  The message may be localized.  | [optional] 
**ChangeTag** | **string** | The user entered tag to identify the operations and their side effects  | [optional] 
**AuditId** | **string** | Specifies the name of the audit event.  The value must never be empty. If unset, the event is not related to auditable activity.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

