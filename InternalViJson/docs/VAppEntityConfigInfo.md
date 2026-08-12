# Vcenter.ViJson.OpenApi.Model.VAppEntityConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | [**ManagedObjectReference**](ManagedObjectReference.md) | Entity to power on or power off.  This can be a virtual machine or a vApp.  Refers instance of *ManagedEntity*.  | [optional] 
**Tag** | **string** | Tag for entity.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**StartOrder** | **int** | Specifies the start order for this entity.  Entities are started from lower numbers to higher-numbers and reverse on shutdown. Multiple entities with the same start-order can be started in parallel and the order is unspecified. This value must be 0 or higher.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**StartDelay** | **int** | Delay in seconds before continuing with the next entity in the order of entities to be started.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**WaitingForGuest** | **bool** | Determines if the virtual machine should start after receiving a heartbeat, from the guest.  When a virtual machine is next in the start order, the system either waits a specified period of time for a virtual machine to power on or it waits until it receives a successful heartbeat from a powered on virtual machine. By default, this is set to false.  This property has no effect for vApps.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**StartAction** | **string** | How to start the entity.  Valid settings are none or powerOn. If set to none, then the entity does not participate in auto-start.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**StopDelay** | **int** | Delay in seconds before continuing with the next entity in the order sequence.  This is only used if the stopAction is guestShutdown.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**StopAction** | **string** | Defines the stop action for the entity.  Can be set to none, powerOff, guestShutdown, or suspend. If set to none, then the entity does not participate in auto-stop.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 
**DestroyWithParent** | **bool** | Deprecated as of vSphere API 5.1.  Whether the entity should be removed, when this vApp is removed.  This is only set for linked children.  Reconfigure privilege: VApp.ApplicationConfig  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

