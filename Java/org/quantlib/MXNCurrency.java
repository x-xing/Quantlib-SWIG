/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class MXNCurrency extends Currency {
  private transient long swigCPtr;

  protected MXNCurrency(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.MXNCurrency_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(MXNCurrency obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_MXNCurrency(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public MXNCurrency() {
    this(QuantLibJNI.new_MXNCurrency(), true);
  }

}
