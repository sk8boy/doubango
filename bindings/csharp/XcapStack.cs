/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class XcapStack : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XcapStack(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(XcapStack obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~XcapStack() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        tinyWRAPPINVOKE.delete_XcapStack(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public XcapStack(XcapCallback callback, string xui, string password, string xcap_root) : this(tinyWRAPPINVOKE.new_XcapStack(XcapCallback.getCPtr(callback), xui, password, xcap_root), true) {
  }

  public bool start() {
    bool ret = tinyWRAPPINVOKE.XcapStack_start(swigCPtr);
    return ret;
  }

  public bool setCredentials(string xui, string password) {
    bool ret = tinyWRAPPINVOKE.XcapStack_setCredentials(swigCPtr, xui, password);
    return ret;
  }

  public bool setXcapRoot(string xcap_root) {
    bool ret = tinyWRAPPINVOKE.XcapStack_setXcapRoot(swigCPtr, xcap_root);
    return ret;
  }

  public bool setLocalIP(string ip) {
    bool ret = tinyWRAPPINVOKE.XcapStack_setLocalIP(swigCPtr, ip);
    return ret;
  }

  public bool setLocalPort(uint port) {
    bool ret = tinyWRAPPINVOKE.XcapStack_setLocalPort(swigCPtr, port);
    return ret;
  }

  public bool addHeader(string name, string value) {
    bool ret = tinyWRAPPINVOKE.XcapStack_addHeader(swigCPtr, name, value);
    return ret;
  }

  public bool removeHeader(string name) {
    bool ret = tinyWRAPPINVOKE.XcapStack_removeHeader(swigCPtr, name);
    return ret;
  }

  public bool setTimeout(uint timeout) {
    bool ret = tinyWRAPPINVOKE.XcapStack_setTimeout(swigCPtr, timeout);
    return ret;
  }

  public bool getDocument(string url) {
    bool ret = tinyWRAPPINVOKE.XcapStack_getDocument(swigCPtr, url);
    return ret;
  }

  public bool stop() {
    bool ret = tinyWRAPPINVOKE.XcapStack_stop(swigCPtr);
    return ret;
  }

}

}