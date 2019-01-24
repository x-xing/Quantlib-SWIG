/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class CustomRegion extends Region {
  private transient long swigCPtr;

  protected CustomRegion(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.CustomRegion_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(CustomRegion obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_CustomRegion(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public CustomRegion(String name, String code) {
    this(QuantLibJNI.new_CustomRegion(name, code), true);
  }

}