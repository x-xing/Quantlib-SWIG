/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class BackwardFlat {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected BackwardFlat(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(BackwardFlat obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_BackwardFlat(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public BackwardFlat() {
    this(QuantLibJNI.new_BackwardFlat(), true);
  }

}
