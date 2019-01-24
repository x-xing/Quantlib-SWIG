/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class YoYInflationCap extends YoYInflationCapFloor {
  private transient long swigCPtr;

  protected YoYInflationCap(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.YoYInflationCap_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(YoYInflationCap obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_YoYInflationCap(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public YoYInflationCap(Leg leg, DoubleVector capRates) {
    this(QuantLibJNI.new_YoYInflationCap(Leg.getCPtr(leg), leg, DoubleVector.getCPtr(capRates), capRates), true);
  }

}