# Vcenter.ViJson.OpenApi.Model.VirtualDeviceConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operation** | **VirtualDeviceConfigSpecOperationEnum** | Type of operation being performed on the specified virtual device.  If no operation is specified, the spec. is ignored.  | [optional] 
**FileOperation** | **VirtualDeviceConfigSpecFileOperationEnum** | Type of operation being performed on the backing of the specified virtual device.  If no file operation is specified in the VirtualDeviceSpec, then any backing filenames in the *VirtualDevice* must refer to files that already exist. The \&quot;replace\&quot; and \&quot;delete\&quot; values for this property are only applicable to virtual disk backing files.  | [optional] 
**Device** | [**VirtualDevice**](VirtualDevice.md) | Device specification, with all necessary properties set.  | 
**Profile** | [**List&lt;VirtualMachineProfileSpec&gt;**](VirtualMachineProfileSpec.md) | Virtual Device Profile requirement.  Profiles are solution specifics. Storage Profile Based Management(SPBM) is a vSphere server extension. The API users who want to provision VMs using Storage Profiles, need to interact with SPBM service. This is an optional parameter and if user doesn&#39;t specify profile, the default behavior will apply.  | [optional] 
**Backing** | [**VirtualDeviceConfigSpecBackingSpec**](VirtualDeviceConfigSpecBackingSpec.md) | BackingInfo configuration options.  Each BackingSpec corresponds to a BackingInfo object. The member *VirtualDeviceConfigSpec.backing* refers to the *VirtualDeviceConfigSpec.device*.*VirtualDevice.backing*.  | [optional] 
**FilterSpec** | [**List&lt;VirtualMachineBaseIndependentFilterSpec&gt;**](VirtualMachineBaseIndependentFilterSpec.md) | List of independent filters *VirtualMachineIndependentFilterSpec* to configure on the virtual device.  ***Since:*** vSphere API Release 7.0.2.1  | [optional] 
**ChangeMode** | **string** | The change mode of the device.  The values of the mode will be one of *VirtualDeviceConfigSpecChangeMode_enum* enumerations. On unset, default to &#39;fail&#39;.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

