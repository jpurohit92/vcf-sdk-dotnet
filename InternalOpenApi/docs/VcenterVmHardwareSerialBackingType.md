# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareSerialBackingType
The Vcenter.Vm.Hardware.Serial.BackingType enumerated type defines the valid backing types for a virtual serial port.  Possible values:   - `FILE`: Virtual serial port is backed by a file.   - `HOST_DEVICE`: Virtual serial port is backed by a device on the host where the virtual machine is running.   - `PIPE_SERVER`: Virtual serial port is backed by a named pipe server. The virtual machine will accept a connection from a host application or another virtual machine on the same host. This is useful for capturing debugging information sent through the virtual serial port.   - `PIPE_CLIENT`: Virtual serial port is backed by a named pipe client. The virtual machine will connect to the named pipe provided by a host application or another virtual machine on the same host. This is useful for capturing debugging information sent through the virtual serial port.   - `NETWORK_SERVER`: Virtual serial port is backed by a network server. This backing may be used to create a network-accessible serial port on the virtual machine, accepting a connection from a remote system.   - `NETWORK_CLIENT`: Virtual serial port is backed by a network client. This backing may be used to create a network-accessible serial port on the virtual machine, initiating a connection to a remote system. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

