# Vcenter.ViJson.OpenApi.Model.VAppConfigInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Product** | [**List&lt;VAppProductInfo&gt;**](VAppProductInfo.md) | Information about the package content.  | [optional] 
**Property** | [**List&lt;VAppPropertyInfo&gt;**](VAppPropertyInfo.md) | List of properties  | [optional] 
**IpAssignment** | [**VAppIPAssignmentInfo**](VAppIPAssignmentInfo.md) | IP assignment policy and DHCP support configuration.  | 
**Eula** | **List&lt;string&gt;** | End User Licenses Agreements.  | [optional] 
**OvfSection** | [**List&lt;VAppOvfSectionInfo&gt;**](VAppOvfSectionInfo.md) | List of uninterpreted OVF meta-data sections.  | [optional] 
**OvfEnvironmentTransport** | **List&lt;string&gt;** | List the transports to use for properties.  Supported values are: iso and com.vmware.guestInfo.  | [optional] 
**InstallBootRequired** | **bool** | Specifies whether the VM needs an initial boot before the deployment is complete.  Not relevant for vApps. This means that the value is always false when reading the configuration and is ignored when setting the configuration.  If a vApp requires an install boot (because one of its VMs does), this is visible on the *VirtualAppSummary.installBootRequired* field of the vApp.  | 
**InstallBootStopDelay** | **int** | Specifies the delay in seconds to wait for the VM to power off after the initial boot (used only if installBootRequired is true).  A value of 0 means wait forever.  Not relevant for vApps. This means that the value is always false when reading the configuration and is ignored when setting the configuration.  | 
**EntityConfig** | [**List&lt;VAppEntityConfigInfo&gt;**](VAppEntityConfigInfo.md) | Configuration of sub-entities (virtual machine or vApp).  | [optional] 
**Annotation** | **string** | Description for the vApp.  | 
**InstanceUuid** | **string** | vCenter-specific 128-bit UUID of a vApp, represented as a hexadecimal string.  This identifier is used by vCenter to uniquely identify all vApp instances.  | [optional] 
**ManagedBy** | [**ManagedByInfo**](ManagedByInfo.md) | Specifies that this vApp is managed by a VC Extension.  See the *managedBy* property in the VAppConfigSpec for more details.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

