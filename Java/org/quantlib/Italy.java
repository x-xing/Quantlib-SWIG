/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class Italy extends Calendar {
  private transient long swigCPtr;

  protected Italy(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.Italy_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(Italy obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_Italy(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public Italy(Italy.Market m) {
    this(QuantLibJNI.new_Italy__SWIG_0(m.swigValue()), true);
  }

  public Italy() {
    this(QuantLibJNI.new_Italy__SWIG_1(), true);
  }

  public final static class Market {
    public final static Italy.Market Settlement = new Italy.Market("Settlement");
    public final static Italy.Market Exchange = new Italy.Market("Exchange");

    public final int swigValue() {
      return swigValue;
    }

    public String toString() {
      return swigName;
    }

    public static Market swigToEnum(int swigValue) {
      if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
        return swigValues[swigValue];
      for (int i = 0; i < swigValues.length; i++)
        if (swigValues[i].swigValue == swigValue)
          return swigValues[i];
      throw new IllegalArgumentException("No enum " + Market.class + " with value " + swigValue);
    }

    private Market(String swigName) {
      this.swigName = swigName;
      this.swigValue = swigNext++;
    }

    private Market(String swigName, int swigValue) {
      this.swigName = swigName;
      this.swigValue = swigValue;
      swigNext = swigValue+1;
    }

    private Market(String swigName, Market swigEnum) {
      this.swigName = swigName;
      this.swigValue = swigEnum.swigValue;
      swigNext = this.swigValue+1;
    }

    private static Market[] swigValues = { Settlement, Exchange };
    private static int swigNext = 0;
    private final int swigValue;
    private final String swigName;
  }

}
