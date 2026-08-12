# Vcenter.ViJson.OpenApi.Model.VirtualVideoCardOption

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The name of the run-time class the client should instantiate to create a run-time instance of this device.  | 
**ConnectOption** | [**VirtualDeviceConnectOption**](VirtualDeviceConnectOption.md) | If the device is connectable, then the connectOption describes the connect options and defaults.  | [optional] 
**BusSlotOption** | [**VirtualDeviceBusSlotOption**](VirtualDeviceBusSlotOption.md) | If the device can use a bus slot configuration, then the busSlotOption describes the bus slot options.  | [optional] 
**ControllerType** | **string** | Data object type that denotes the controller option object that is valid for controlling this device.  | [optional] 
**AutoAssignController** | [**BoolOption**](BoolOption.md) | Flag to indicate whether or not this device will be auto-assigned a controller if one is required.  If this is true, then a client need not explicitly create the controller that this device will plug into.  | [optional] 
**BackingOption** | [**List&lt;VirtualDeviceBackingOption&gt;**](VirtualDeviceBackingOption.md) | A list of backing options that can be used to map the virtual device to the host.  The list is optional, since some devices exist only within the virtual machine; for example, a VirtualController.  | [optional] 
**DefaultBackingOptionIndex** | **int** | Index into the backingOption list, indicating the default backing.  | [optional] 
**LicensingLimit** | **List&lt;string&gt;** | List of property names enforced by a licensing restriction of the underlying product.  For example, a limit that is not derived based on the product or hardware features; the property name \&quot;numCPU\&quot;.  | [optional] 
**Deprecated** | **bool** | Indicates whether this device is deprecated.  Hence, if set the device cannot be used when creating a new virtual machine or be added to an existing virtual machine. However, the device is still supported by the platform.  | 
**PlugAndPlay** | **bool** | Indicates if this type of device can be hot-added to the virtual machine via a reconfigure operation when the virtual machine is powered on.  | 
**HotRemoveSupported** | **bool** | Indicates if this type of device can be hot-removed from the virtual machine via a reconfigure operation when the virtual machine is powered on.  | 
**NumaSupported** | **bool** | ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**VideoRamSizeInKB** | [**LongOption**](LongOption.md) | Minimum, maximum and default size of the video frame buffer.  | [optional] 
**NumDisplays** | [**IntOption**](IntOption.md) | Minimum, maximum and default value for the number of displays.  | [optional] 
**UseAutoDetect** | [**BoolOption**](BoolOption.md) | Flag to indicate whether the display settings of the host should be used to automatically determine the display settings of the virtual machine&#39;s video card.  | [optional] 
**Support3D** | [**BoolOption**](BoolOption.md) | Flag to indicate whether the virtual video card supports 3D functions.  | [optional] 
**Use3dRendererSupported** | [**BoolOption**](BoolOption.md) | Flag to indicate whether the virtual video card can specify how to render 3D graphics.  | [optional] 
**GraphicsMemorySizeInKB** | [**LongOption**](LongOption.md) | The minimum, maximum, and default values for graphics memory size.  | [optional] 
**GraphicsMemorySizeSupported** | [**BoolOption**](BoolOption.md) | Flag to indicate whether the virtual video card can specify the size of graphics memory.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

