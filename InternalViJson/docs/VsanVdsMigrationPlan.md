# Vcenter.ViJson.OpenApi.Model.VsanVdsMigrationPlan

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VdsSpec** | [**DVSCreateSpec**](DVSCreateSpec.md) | VDS creation spec.  Contains information about host members, and their pNICs.  | 
**Pgs** | [**List&lt;VsanVdsPgMigrationSpec&gt;**](VsanVdsPgMigrationSpec.md) | Migration specs for all portgroups.  All policies are preserved for the consumers of these portgroups.  | [optional] 
**InaccessibleVms** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | A list of inaccessible or orphaned VMs which are blocking the migration.  Refers instances of *VirtualMachine*.  | [optional] 
**InfraVms** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | This is includes any infra VM which was explicitly provided by the user as well as possibly an auto-detected vCenter.  vCenter is auto-detected by comparing the IP of vCenter to the IP of VMs on the VSS, and if a match is found the VM is added to the list. Note that dependent VMs like an external VC DB, a DHCP or DNS server, or similar infrastructure VMs will not be auto-detected.  Refers instances of *VirtualMachine*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

